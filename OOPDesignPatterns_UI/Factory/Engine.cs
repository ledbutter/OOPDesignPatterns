using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDesignPatterns.Factory
{
    internal abstract class Engine
    {
        public int Cylinders { get; protected set; }

        public int Horsepower { get; protected set; }
    }

    internal class BaseEngine : Engine
    {
        public BaseEngine()
        {
            this.Cylinders = 4;
            this.Horsepower = 150;
        }
    }

    internal class DieselEngine : Engine
    {
        public DieselEngine()
        {
            this.Cylinders = 4;
            this.Horsepower = 175;
        }
    }

    internal class TurboEngine : Engine
    {
        public TurboEngine()
        {
            this.Cylinders = 6;
            this.Horsepower = 250;
        }
    }
}
