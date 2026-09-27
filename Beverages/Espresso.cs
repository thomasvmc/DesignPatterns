using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class Espresso : BaseBeverage
    {
        public Espresso(SizeEnum? size, Beverage? beverage = null) : base(size, beverage)
        {
            description = "Espresso";
            this.baseBeverage = beverage;
            Cost = 1.99;
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
