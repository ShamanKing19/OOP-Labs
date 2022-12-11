using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    public class Roof
    {
        public string Material { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }

        public Roof(string material, double price, double weight)
        {
            Material = material;
            Price = price;
            Weight = weight;
        }
    }
}
