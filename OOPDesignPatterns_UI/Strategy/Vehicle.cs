using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Console;

namespace OOPDesignPatterns.Strategy
{
    /// <summary>
    /// A vehicle is a mechanical means of location.
    /// </summary>
    internal abstract class Vehicle
    {
        /*
            What behaviors do all of our vehicles have?
            What changes?
        */

        public void Move()
        {
            WriteLine("The vehicle {0} is moving", Name);
        }


        public void Start()
        {
            WriteLine("The vehicle {0} is started", Name);
        }

        public void Stop()
        {
            WriteLine("The vehicle {0} is stopped", Name);
        }

        public void Turn(TurnDirection direction)
        {
            WriteLine("The vehicle {0} is turning {1}", Name, Enum.GetName(typeof(TurnDirection), direction).ToLower());
        }

        public abstract string Name { get; }

    }

    internal class Car : Vehicle 
    {

        public Car(string make, string model)
        {
            Make = make;
            Model = model;
        }
        public string Make { get; private set; }

        public string Model { get; private set; }

        public override string Name
        {
            get
            {
                return string.Format("{0} {1}", Make, Model);
            }
        }
    }

    internal class Motorcycle : Vehicle
    {
        public string Make { get; private set; }

        public Motorcycle(string make)
        {
            Make = make;
        }

        public override string Name
        {
            get
            {
                return Make;
            }
        }
    }

    internal class Train : Vehicle
    {
        public override string Name
        {
            get
            {
                return "Choo Choo Train";
            }
        }
    }
}
