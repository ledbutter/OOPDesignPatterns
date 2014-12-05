using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Console;

namespace OOPDesignPatterns.Strategy
{
    internal abstract class PatternedVehicle
    {
        /*
            So now we understand that all vehicles start, stop, and go, but not all of them can turn
        */
        private ITurnBehavior TurnBehavior { get; set; }

        public PatternedVehicle(ITurnBehavior turnBehavior)
        {
            TurnBehavior = turnBehavior;
        }

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
            TurnBehavior.Turn(direction);
        }

        public abstract string Name { get; }
    }

    internal class PatternedCar : PatternedVehicle
    {

        public PatternedCar(string make, string model) : base(new CarTurnBehavior())
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

    internal class PatternedMotorcycle : PatternedVehicle
    {
        public string Make { get; private set; }

        public PatternedMotorcycle(string make) : base(new TwoWheelTurnBehavior())
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

    internal class PatternedTrain : PatternedVehicle
    {
        public override string Name
        {
            get
            {
                return "Choo Choo Train";
            }
        }

        public PatternedTrain() : base(new TrackTurnBehavior()) { }
    }
}
