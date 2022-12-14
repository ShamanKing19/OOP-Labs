using System;
using System.Threading;
using System.Collections.Generic;
using Laba2;

namespace Laba4
{
    class App
    {
        static void Main(string[] args)
        {
            House house = new House();
            
            TeamLeader leader = new TeamLeader("Артас", 10000, "За моего отца!");
            Worker worker1 = new Worker("Работник 1", 37, "Что-то делает 1", 2000);
            Worker worker2 = new Worker("Работник 2", 52, "Что-то делает 2", 1500);
            Worker worker3 = new Worker("Работник 3", 20, "Что-то делает 3", 800);
            Worker worker4 = new Worker("Работник 4", 31, "Что-то делает 4", 5000);
            Worker worker5 = new Worker("Работник 4", 31, "Что-то делает 5", 5000);

            Team team = new Team(leader);
            team.Hire(worker1);
            team.Hire(worker2);
            team.Hire(worker3);
            team.Hire(worker4);
            team.Hire(worker5);

            Random random = new Random();

            bool isBuildingInProcess = true;
            while (isBuildingInProcess)
            {
                foreach (Worker worker in team.Workers)
                {
                    isBuildingInProcess = worker.BuildHouse(house);
                    bool isLeaderWantsToCheck = random.Next(100) < 50;
                    if (isLeaderWantsToCheck)
                    {
                        leader.CheckBuildingProcess(house);
                    }
                    Thread.Sleep(500);
                }
            }

            Console.WriteLine("\nДом построен!");

            Laba2.Laba2.PrintHouse(10, 35, Color.Blue, Color.Red, Color.Magenta, Color.Cyan);
            Console.ReadKey();
        }
    }
}
