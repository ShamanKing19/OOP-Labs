using System;

namespace Data
{
    public class Car
    {
        public string Brand { get; set; }
        public string CarClass { get; set; }
        public int Weight { get; set; }
        public Driver Driver { get; set; }
        public Engine Engine { get; set; }


        public Car(string brand, string carClass, int weight, Driver driver, Engine engine)
        {
            Brand = brand;
            CarClass = carClass;
            Weight = weight;
            Driver = driver;
            Engine = engine;
        }

        public void Start()
        {
            Console.WriteLine("Поехали");
        }

        public void Stop()
        {
            Console.WriteLine("Останавливаемся");
        }

        public void TurnRight()
        {
            Console.WriteLine("Поворот направо");
        }

        public void TurnLeft()
        {
            Console.WriteLine("Поворот налево");
        }

        public override string ToString()
        {
            return $"Бренд: {Brand} Класс машины: {CarClass} {Weight} Водитель: {Driver} Двигатель: {Engine}";
        }

    }
}
