using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    public class TeamLeader
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Battlecry { get; set; }

        public TeamLeader(string name, double salary, string battlecry)
        {
            Name = name;
            Salary = salary;
            Battlecry = battlecry;
        }

        public void CheckBuildingProcess(House house)
        {
            if (house.Basement is null)
            {
                Console.WriteLine("\nПока что построен лишь фундамент\n");
            }
            else if (house.Walls is null || house.Walls.Count < 4)
            {
                Console.WriteLine($"\nПостроено следующее количество стен {house.Walls.Count}\n");
            }
            else if (house.Roof is null)
            {
                Console.WriteLine("\nУже сделана крыша!\n");
            }
            else if (house.Door is null)
            {
                Console.WriteLine("\nНаконец-то есть дверь...\n");
            }
            else if (house.Windows is null || house.Windows.Count < 4)
            {
                Console.WriteLine($"\nУже готово столько окон: {house.Windows.Count}\n");
            }
        }
    }
}
