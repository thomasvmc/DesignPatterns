using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class DarkRoast : BaseBeverage
    {
        public DarkRoast(SizeEnum? size, Beverage? beverage = null) : base(size, beverage)
        {
            description = "Dark roast";
            this.baseBeverage = beverage;
            Cost = 1.53;
        }
        public override string GetDescription()
        {
            if (baseBeverage != null)
            {
                return baseBeverage.GetDescription() + ", " + description;
            }
            return description;
        }
    }
}