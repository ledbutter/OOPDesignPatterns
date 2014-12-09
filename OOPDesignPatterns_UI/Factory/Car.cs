using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDesignPatterns.Factory
{
    internal abstract class Car
    {
        protected Engine CarEngine { get; set; }

        public Car()
        {
            this.RetrieveEngine();
        }

        public string EngineDescription { get
            {
                return string.Format("{0} cylinders with {1} horsepower", CarEngine.Cylinders, CarEngine.Horsepower);
            }
        }

        //Let implementers figure out which engine they need
        public abstract void RetrieveEngine();
    }

    internal class BaseModel : Car
    {
        public override void RetrieveEngine()
        {
            CarEngine = new BaseEngine();
        }
    }

    internal class EuroModel : Car
    {
        public override void RetrieveEngine()
        {
            CarEngine = new DieselEngine();
        }
    }

    internal class SportModel : Car
    {
        public override void RetrieveEngine()
        {
            CarEngine = new TurboEngine();
        }
    }
}
