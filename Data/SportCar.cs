using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class SportCar : Car
    {
        public double MaxSpeed { get; set; }

        public SportCar(string brand, string carClass, int weight, Driver driver, Engine engine, double maxSpeed) : base(brand, carClass, weight, driver, engine)
        {
            MaxSpeed = maxSpeed;
        }

    }
}
