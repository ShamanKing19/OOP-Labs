using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Engine
    {
        public int Power { get; }
        public string Manufacturer { get; }

        public Engine(int power, string manufacturer)
        {
            Power = power;
            Manufacturer = manufacturer;
        }

        public override string ToString()
        {
            return $"Мощность: {Power} Производитель: {Manufacturer}";
        }

    }
}
