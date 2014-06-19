using OrderRules.Interface;
using OrderTaker.SharedObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderRule.NameBadge
{
    public class NameBadgeRule : IOrderRule
    {
        public string RuleName
        {
            get { return Properties.Resources.NameBadge_RuleName; }
        }

        public OrderRuleResult CheckRule(Order order)
        {
            var passed = true;
            var message = string.Empty;

            foreach (var item in order.OrderItems)
                if ((item.ProductItem.ProductId == 9 ||
                    item.ProductItem.ProductId == 10 ||
                    item.ProductItem.ProductId == 11 )
                    && !item.ProductItem.ProductName.Contains(order.Customer.FirstName))
                {
                    passed = false;
                    message = string.Format(Properties.Resources.NameBadge_Message,
                                            order.Customer.FirstName);
                }

            return new OrderRuleResult(passed, message);
        }
    }
}
