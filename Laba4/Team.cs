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
            //Thread.Sleep(500);
        }

        public bool Work()
        {
            int workersCount = this.Workers.Count;
            bool haveWorkers = workersCount > 0;

            if (haveWorkers) {
                Console.WriteLine($"\nБригада из {workersCount} рабочих начала работу\n");
            } else {
                Console.WriteLine("\nНекому работать :D\n");
            }

            return haveWorkers;
        }
    }
}
