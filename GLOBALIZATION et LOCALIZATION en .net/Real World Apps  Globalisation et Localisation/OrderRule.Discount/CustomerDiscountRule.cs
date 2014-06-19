﻿using OrderRules.Interface;
using OrderTaker.SharedObjects;

namespace OrderRule.Discount
{
    public class CustomerDiscountRule : IOrderRule
    {
        public string RuleName
        {
            get { return Properties.Resources.CustomerDiscount_RuleName; }
        }

        public OrderRuleResult CheckRule(Order order)
        {
            // Maximum discount based on Customer Rating
            var passed = true;
            var message = string.Empty;
            switch (order.Customer.Rating)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    if (order.OrderDiscount > 0)
                    {
                        passed = false;
                        message = string.Format(
                            Properties.Resources.CustomerDiscount_Message,
                            0, order.Customer.Rating);
                    }
                    break;
                case 4:
                case 5:
                case 6:
                    if (order.OrderDiscount > 5)
                    {
                        passed = false;
                        message = string.Format(
                            Properties.Resources.CustomerDiscount_Message,
                            5, order.Customer.Rating);
                    }
                    break;
                case 7:
                case 8:
                    if (order.OrderDiscount > 10)
                    {
                        passed = false;
                        message = string.Format(
                            Properties.Resources.CustomerDiscount_Message,
                            10, order.Customer.Rating);
                    }
                    break;
                case 9:
                case 10:
                    if (order.OrderDiscount > 15)
                    {
                        passed = false;
                        message = string.Format(
                            Properties.Resources.CustomerDiscount_Message,
                            15, order.Customer.Rating);
                    }
                    break;
                default:
                    break;
            }
            return new OrderRuleResult(passed, message);
        }
    }
}
