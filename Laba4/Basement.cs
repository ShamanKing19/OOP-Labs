using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    public class Basement : IPart
    {
        public string Material { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }

        public Basement(string material, double price, double weight)
        {
            Material = material;
            Price = price;
            Weight = weight;
        }
    }
}
