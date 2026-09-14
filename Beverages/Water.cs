using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class Water : Beverage
    {
        public Water(Beverage? beverage = null)
        {
            description = "Water";
            this.baseBeverage = beverage ?? throw new ArgumentNullException(nameof(beverage));
            Cost = 50;
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
