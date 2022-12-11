using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    public class House
    {
        public Basement Basement { get; set; }
        public List<Wall> Walls {get; set;}
        public List<Window> Windows { get; set; }
        public Roof Roof { get; set; }
        public Door Door { get; set; }

        public House()
        {
            Walls = new List<Wall>();
            Windows = new List<Window>();
        }
    }
}
