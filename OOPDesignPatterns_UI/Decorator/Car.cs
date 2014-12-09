using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDesignPatterns.Decorator
{
    internal abstract class Car
    {
        public abstract string Name { get; }

        public abstract decimal Price { get; }
    }

    internal class BaseModel : Car
    {
        public override string Name
        {
            get
            {
                return "Fully Equipped Base Model";
            }
        }

        public override decimal Price
        {
            get
            {
                return 19999.95m;
            }
        }
    }

    internal class WinterPackage : Car
    {
        public override string Name
        {
            get
            {
                return "Fully Equipped plus winter accessories";
            }
        }

        public override decimal Price
        {
            get
            {
                //prices of the packages based on the base model price plus whatever arbitrary charge the dealer wants to add on
                return 21500.95m;
            }
        }
    }

    internal class SportPackage : Car
    {
        public override string Name
        {
            get
            {
                return "Base model plus overpriced rims";
            }
        }

        public override decimal Price
        {
            get
            {
                return 23500.95m;
            }
        }
    }

    internal class DeluxePackage : Car
    {
        public override string Name
        {
            get
            {
                return "Overpriced badging and leather";
            }
        }

        public override decimal Price
        {
            get
            {
                return 26999.95m;
            }
        }
    }
    //so far, so good, but what about cases with multiple packages?

    internal class WinterAndSportPackage : Car
    {
        public override string Name
        {
            get
            {
                return "Both winter accessories and overpriced rims!";
            }
        }

        public override decimal Price
        {
            get
            {
                return 25950.95m;
            }
        }
    }

    /*
        We find ourselves now in a situation where for every new package introduced, we need to create a new set of classes
        to account for every combination of packages to support.
    */
}
