using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Laba4
{
    public class Team
    {
        public TeamLeader Leader { get; set; }
        public List<Worker> Workers { get; set; }

        public Team(TeamLeader leader)
        {
            Leader = leader;
            Workers = new List<Worker>();
        }

        public void Hire(Worker worker)
        {
            Console.WriteLine($"Нанят новый работник: {worker.Name} на должность {worker.Position} с з/п {worker.Salary}");
            this.Workers.Add(worker);
        }
    }
}
