using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    enum Size
    {
        TALL,
        GRANDE,
        VENDI
    }
    
    internal abstract class Beverage
    {
        public Size Size { get { return size; } set { size = value; } }
        private Size size;
        protected double Cost = 0;

        protected string description = "Unknown";
        protected Beverage? baseBeverage = null;
        

        public virtual string GetDescription()
        {
            return description;
        }

        public virtual double cost()
        {
            return size switch
            {
                Size.TALL => 20,
                Size.GRANDE => 40,
                Size.VENDI => 60,
                _ => 0
            } + baseBeverage?.cost() ?? 0 + Cost;
        }
    }
}