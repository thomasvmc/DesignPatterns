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
                    SizeEnum.TALL => 20,
                    SizeEnum.GRANDE => 40,
                    SizeEnum.VENDI => 60
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
            return baseBeverage?.cost() ?? 0 + Cost;
        }
    }
}