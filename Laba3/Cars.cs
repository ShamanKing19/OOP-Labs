using System;
using Data;

namespace Laba3
{
    class Cars
    {
        static void Main(string[] args)
        {
            Person person = new Person("Чувак без прав", "Украли старшекласснки", 2012, "М");
            Console.WriteLine(person);

            Driver driver = new Driver("Георгий", "891198989898", 2000, "М", 4.5);
            Console.WriteLine(driver);

            Engine engine = new Engine(272, "Mercedes");
            Console.WriteLine(engine);

            Console.WriteLine();

            Car car = new Car("Mercedes", "ML", 2800, driver, engine);
            Console.WriteLine(car);
            car.Start();
            car.TurnRight();
            car.TurnLeft();
            car.Stop();

            Console.WriteLine();

            Engine sportEngine = new Engine(400, "WAG");
            SportCar sportCar = new SportCar("Porshe", "SuperCar", 1200, driver, sportEngine, 350);
            Console.WriteLine(sportCar);
            sportCar.Start();
            sportCar.TurnRight();
            sportCar.TurnRight();
            sportCar.TurnRight();
            sportCar.TurnRight();
            sportCar.TurnRight();
            sportCar.Stop();

            Console.WriteLine();

            Driver lorryDriver = new Driver("Петрович", "Потерял", 1970, "2 раза в неделю", 32);
            Engine lorryEngine = new Engine(600, "Renault");
            Lorry lorry = new Lorry("Renault", "БОЛЬШАЯ МАШИНА", 6300, lorryDriver, lorryEngine, 20000);
            Console.WriteLine(lorry);
            lorry.Start();
            lorry.Start();
            lorry.Start();
            Console.WriteLine("Снова не завёлся...");
        }
    }
}
