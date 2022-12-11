using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    interface IWorker
    {
        string Name { get; set; }
        int Age { get; set; }
        string Position { get; set; }
        double Salary { get; set; }
    }
}
