using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laba4
{
    public class Worker : IWorker
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }

        public Worker(string name, int age, string position, double salary)
        {
            Name = name;
            Age = age;
            Position = position;
            Salary = salary;
        }

        public bool BuildHouse(House house)
        {
            if (house.Basement is null)
            {
                house.Basement = this.CreateBasement();
                Console.WriteLine("Построен фундамент");
                return true;
            }
            else if (house.Walls is null || house.Walls.Count < 4)
            {
                Wall wall = this.CreateWall();
                house.Walls.Add(wall);
                Console.WriteLine($"Построена стена №{house.Walls.Count}");
                return true;
            }
            else if (house.Roof is null)
            {
                house.Roof = this.CreateRoof();
                Console.WriteLine("Построена крыша");
                return true;
            }
            else if (house.Door is null)
            {
                house.Door = this.CreateDoor();
                Console.WriteLine("Построена дверь");
                return true;
            }
            else if (house.Windows is null || house.Windows.Count < 4)
            {
                Window window = this.CreateWindow();
                house.Windows.Add(window);
                Console.WriteLine($"Построено окно №{house.Windows.Count}");
                return true;
            }

            return false;
        }

        public Basement CreateBasement()
        {
            return new Basement("Бетон", 586.2, 123.4);
        }

        public Wall CreateWall()
        {
            return new Wall("Бетон", 666, 50);
        }

        public Door CreateDoor()
        {
            return new Door("Дерево", 50, 99);
        }

        public Roof CreateRoof()
        {
            return new Roof("Черепица", 80, 40);
        }

        public Window CreateWindow()
        {
            return new Window("Пластик", 40, 10);
        }
    }
}
