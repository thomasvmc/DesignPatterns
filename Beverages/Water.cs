using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class Water : BaseBeverage
    {
        public Water(SizeEnum size, Beverage? beverage = null) : base(size, beverage)
        {
            description = "Water";
            this.baseBeverage = beverage ?? throw new ArgumentNullException(nameof(beverage));
            Cost = 0.50;
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
