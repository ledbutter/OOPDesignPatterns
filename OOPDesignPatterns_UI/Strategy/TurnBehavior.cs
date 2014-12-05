using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Console;

namespace OOPDesignPatterns.Strategy
{
    /// <summary>
    /// Defines the functionality needed to support turning a vehicle.
    /// </summary>
    internal interface ITurnBehavior
    {
        void Turn(TurnDirection direction);
    }

    /// <summary>
    /// Implementation of turn behavior for cars (e.g. sedans, SUV's, trucks).
    /// </summary>
    internal class CarTurnBehavior : ITurnBehavior
    {
        public void Turn(TurnDirection direction)
        {
            WriteLine("The car turns by using the steering wheel");
        }
    }

    /// <summary>
    /// Implementation of turn behavior for two-wheeled vehicles (e.g. motorcycles, bikes).
    /// </summary>
    internal class TwoWheelTurnBehavior : ITurnBehavior
    {
        public void Turn(TurnDirection direction)
        {
            WriteLine("A two-wheeled vehicle turns by shifting body weight and using the handlebars");
        }
    }

    /// <summary>
    /// Implementation of turn behavior for vehicles on tracks (e.g. trolleys, trains, subways).
    /// </summary>
    internal class TrackTurnBehavior : ITurnBehavior
    {
        public void Turn(TurnDirection direction)
        {
            WriteLine("No turning allowed");
        }
    } 
}
