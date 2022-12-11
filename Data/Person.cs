using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
     public class Person
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public int YearOfbirth { get; set; }
        public string Sex { get; set; }
        
        public Person(string name, string phone, int yearOfbirth, string sex)
        {
            Name = name;
            Phone = phone;
            YearOfbirth = yearOfbirth;
            Sex = sex;
        }

        public override string ToString()
        {
            return $"ФИО: {Name} Телефон: {Phone} Год рождения: {YearOfbirth} Пол: {Sex}";
        }
    }
}
