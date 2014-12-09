using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDesignPatterns.Decorator.Patterned
{
    internal abstract class PatternedCar
    {
        public abstract string Name { get; }

        public abstract decimal Price { get; }
    }

    /// <summary>
    /// The "decorator" base class.
    /// </summary>
    /// <remarks>
    /// Notice that this implements the base class. This is what allows for seamless addition of packages.
    /// </remarks>
    internal abstract class CarPackage : PatternedCar
    {
        private PatternedCar _car;

        public abstract string PackageName { get; }

        public abstract decimal PackagePrice { get; }

        public CarPackage(PatternedCar car)
        {
            _car = car;
        }

        public override string Name
        {
            get
            {
                return string.Format("{0} with {1}", _car.Name, PackageName);
            }
        }

        public override decimal Price
        {
            get
            {
                return _car.Price + PackagePrice;
            }
        }
    }

    /// <summary>
    /// The base, concrete/instantiated car class.
    /// </summary>
    internal class BaseModel : PatternedCar
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

    internal class WinterPackage : CarPackage
    {
        public override string PackageName
        {
            get
            {
                return "Winter package";
            }
        }

        public override decimal PackagePrice
        {
            get
            {
                return 1500.00m;
            }
        }

        public WinterPackage(PatternedCar car) : base(car) {}
    }

    internal class SportPackage : CarPackage
    {
        public override string PackageName
        {
            get
            {
                return "Overpriced rims";
            }
        }

        public override decimal PackagePrice
        {
            get
            {
                return 2000.0m;
            }
        }

        public SportPackage(PatternedCar car) : base(car) {}
    }

    internal class DeluxePackage : CarPackage
    {
        public override string PackageName
        {
            get
            {
                return "Overpriced badging and leather";
            }
        }

        public override decimal PackagePrice
        {
            get
            {
                return 3000.95m;
            }
        }

        public DeluxePackage(PatternedCar car) : base(car) {}
    }
}
