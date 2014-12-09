using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Console;

namespace OOPDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                DisplayMenu();
                var choice = ReadKey();
                WriteLine();
                switch (choice.KeyChar)
                {
                    case '1': //strategy
                        //works great!!!
                        Strategy.Vehicle vehicle = new Strategy.Car("Ford", "Pinto");
                        vehicle.Start();
                        vehicle.Move();
                        vehicle.Turn(Strategy.TurnDirection.Left);
                        vehicle.Stop();
                        //how about a train?
                        vehicle = new Strategy.Train();
                        vehicle.Start();
                        vehicle.Move();
                        //ummm...problem
                        vehicle.Turn(Strategy.TurnDirection.Around);
                        vehicle.Stop();
                        break;
                    case '2': //decorator
                        bool includeWinter = false, includeSport = true, includeDeluxe = false;

                        Decorator.Car car = null;

                        if (!includeWinter && !includeSport && !includeDeluxe)
                        {
                            car = new Decorator.BaseModel();
                        }
                        else if(!includeWinter && !includeSport && includeDeluxe)
                        {
                            car = new Decorator.DeluxePackage();
                        }
                        //and on and on
                        else //if (includeWinter && includeSport && !includeDeluxe)
                        {
                            car = new Decorator.WinterAndSportPackage();
                        }

                        WriteLine("You picked the {0} model for ${1}!", car.Name, car.Price);
                        break;
                    case '3': //factory
                        Factory.Car c = new Factory.SportModel();
                        WriteLine(c.EngineDescription);
                        break;
                    default:
                        return;
                }
                WriteLine("Done!\n\n");
            }
        }

        static void DisplayMenu()
        {
            WriteLine("Welcome to the Object-Oriented Design Patterns Demo");
            WriteLine("Which design pattern should be demonstrated?");
            WriteLine("1) Strategy");
            WriteLine("2) Decorator");
            WriteLine("3) Factory");
            WriteLine("Press any other key to quit");
        }
    }
}
