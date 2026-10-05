using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal abstract class Beverage
    {
        public SizeEnum? Size { get { return size; } set { size = value; } }
        private SizeEnum? size;
        protected double Cost = 0;

        protected Beverage(SizeEnum? size)
        {
            if (size != null)
            {
                this.size = size;
            }
        }

        protected string description = "Unknown";
        protected Beverage? baseBeverage = null;
        

        public virtual string GetDescription()
        {
            return description;
        }

        public virtual double cost()
        {
            return (baseBeverage?.cost() ?? 0) + Cost * sizeMultiplier(size ?? baseBeverage.size);
        }

        private static double sizeMultiplier(SizeEnum? size)
        {
            return size switch
            {
                SizeEnum.GRANDE => 1.25,
                SizeEnum.VENDI => 1.50,
                _ => 1
            };
            
        }
    }
}