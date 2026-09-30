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
                this.size = (SizeEnum) size;
                Cost += size switch
                {
                    SizeEnum.TALL => 0.20,
                    SizeEnum.GRANDE => 0.40,
                    SizeEnum.VENDI => 0.60,
                    _ => throw new ArgumentOutOfRangeException(nameof(size), size, null)
                };
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
            return (baseBeverage?.cost() ?? 0) + Cost;
        }
    }
}