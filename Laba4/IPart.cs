using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    public interface IPart
    {
        string Material { get; set; }
        double Price { get; set; }
        double Weight { get; set; }
    }
}
