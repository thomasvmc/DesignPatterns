using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadePattern.TheaterComponents;

namespace FacadePattern
{
    internal class Tuner
    {
        private Amplifier _amplifier;
        public Tuner(Amplifier amplifier)
        {
            this._amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("Tuner on");
        }

        public void Off()
        {
            Console.WriteLine("Tuner off");
        }

        public void setAM()
        {
            Console.WriteLine("set am to");
        }

        public void setFM()
        {
            Console.WriteLine("set fm to");
        }

        public void setFrequency()
        {
            Console.WriteLine("set frequency to");
        }

    }
}
