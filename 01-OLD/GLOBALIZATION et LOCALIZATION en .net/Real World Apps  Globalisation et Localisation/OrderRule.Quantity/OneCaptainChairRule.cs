using OrderRules.Interface;
using OrderTaker.SharedObjects;

namespace OrderRule.Quantity
{
    public class OneCaptainChairRule : IOrderRule
    {
        public string RuleName
        {
            get { return Properties.Resources.OneCaptainChair_RuleName; }
        }

        public OrderRuleResult CheckRule(Order order)
        {
            var chairCount = 0;
            var passed = true;
            var message = string.Empty;

            foreach(var item in order.OrderItems)
                if (item.ProductItem.ProductId == 2 ||
                    item.ProductItem.ProductId == 3)
                {
                    chairCount += item.Quantity;
                }

            if (chairCount > 1)
            {
                passed = false;
                message = Properties.Resources.OneCaptainChair_Message;
            }
            return new OrderRuleResult(passed, message);
        }

    }
}
