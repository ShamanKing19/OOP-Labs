using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Lorry : Car
    {
        public int LoadCapacity { get; set; }

        public Lorry(string brand, string carClass, int weight, Driver driver, Engine engine, int loadCapacity) : base(brand, carClass, weight, driver, engine)
        {
            LoadCapacity = loadCapacity;
        }

    }
}
