using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class Decaf : Beverage
    {
        public Decaf(Beverage? beverage = null)
        {
            description = "Decaf";
            this.baseBeverage = beverage;
            Cost = 1.39;
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