using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Driver : Person
    {
        public double DrivingExperience { get; set; }

        public Driver(string name, string phone, int yearOfbirth, string sex, double drivingExperience) : base(name, phone, yearOfbirth, sex)
        {
            DrivingExperience = drivingExperience;
        }


        public override string ToString()
        {
            return $"ФИО: {Name} Телефон: {Phone} Год рождения: {YearOfbirth} Пол: {Sex}  Стаж вождения: {DrivingExperience}";
        }

    }
}
