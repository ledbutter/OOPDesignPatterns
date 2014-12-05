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
                switch (choice.KeyChar)
                {
                    case '1':
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
            WriteLine("Press any other key to quit");
        }
    }
}
