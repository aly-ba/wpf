using OrderRules.Interface;
using OrderTaker.SharedObjects;

namespace OrderRule.Quantity
{
    public class MaxStarshipRule : IOrderRule
    {

        public string RuleName
        {
            get { return Properties.Resources.MaxStarship_RuleName; }
        }
        
        public OrderRuleResult CheckRule(Order order)
        {
            var passed = true;
            var message = string.Empty;

            foreach(var item in order.OrderItems)
                if (item.ProductItem.ProductId == 8 &&
                    item.Quantity > 1)
                {
                    passed = false;
                    message = Properties.Resources.MaxStarship_Message;
                }
            return new OrderRuleResult(passed, message);
        }

    }
}
