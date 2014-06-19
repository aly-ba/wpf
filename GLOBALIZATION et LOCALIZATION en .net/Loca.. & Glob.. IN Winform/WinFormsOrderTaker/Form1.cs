using OrderTaker.Data;
using OrderTaker.SharedObjects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace OrderTaker
{
    public partial class Form1 : Form
    {
        private List<Person> customers;
        private List<Product> products;
        private Order order;

        public Form1()
        {
            InitializeComponent();
            PopulateOrderData();
            PopulateCustomerData();
            PopulateProductData();
        }

        public void PopulateCustomerData()
        {
            customers = People.GetPeople();
            customerCombo.Items.Clear();
            foreach (var item in customers)
            {
                customerCombo.Items.Add(string.Format("{0} {1}", item.FirstName, item.LastName));
            }
            customerCombo.SelectedIndex = 0;
        }

        public void PopulateProductData()
        {
            products = Products.GetProducts();
            productCombo.Items.Clear();
            foreach (var item in products)
            {
                productCombo.Items.Add(item.ProductName);
            }
            productCombo.SelectedIndex = 0;
        }

        public void PopulateOrderData()
        {
            order = new Order();
            discountBox.Text = "0";
            totalBox.Text = 0.ToString("C");
            orderBindingSource.DataSource = order;
        }

        private void customerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customerCombo.SelectedIndex >= 0)
            {
                ratingTextbox.Text = customers[customerCombo.SelectedIndex].Rating.ToString();
                customerSinceBox.Text = customers[customerCombo.SelectedIndex].StartDate.ToString("d");
                order.Customer = customers[customerCombo.SelectedIndex];
            }
        }

        private void productCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productCombo.SelectedIndex >= 0)
            {
                unitPriceBox.Text = products[productCombo.SelectedIndex].Price.ToString("C");
                quantityBox.Text = "1";
            }
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            var product = products[productCombo.SelectedIndex];
            var quantity = Int32.Parse(quantityBox.Text);

            if (product != null && quantity > 0)
            {
                var existingProduct = order.OrderItems.FirstOrDefault(p => p.ProductItem == product);

                if (existingProduct == null)
                    order.OrderItems.Add(new OrderItem() { ProductItem = product, Quantity = quantity });
                else
                    existingProduct.Quantity += quantity;
            }
            orderItemsBindingSource.ResetBindings(false);
            totalBox.Text = order.TotalPrice.ToString("C");
        }

        private void submitOrderButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order Submitted");
        }

        private void discountBox_TextChanged(object sender, EventArgs e)
        {
            order.OrderDiscount = Int32.Parse(discountBox.Text);
            totalBox.Text = order.TotalPrice.ToString("C");
        }
    }
}
