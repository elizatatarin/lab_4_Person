using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторна_4
{
    internal class Person
    {
        private string name;
        private int birthYear;
        private DateTime date = DateTime.Today;

        public string Name
        {
            get { return name; }
        }

        public int BirthYear
        {
            get { return birthYear; }
        }

        //Конструктор за замовчуванням
        public Person(): this("Eliza", 2004)
        { }

        //Конструктор з двома параметрами
        public Person(string name, int birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        //Методи

        //Обчислення віку особи
        public void Age()
        {
            birthYear = date.Year - birthYear;
            Console.WriteLine(birthYear);
        }

        //Виведення даних про особу з консолі
        public void Input()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть ім'я:");
            this.name = Console.ReadLine();
            Console.WriteLine("Введіть рік народження:");
            this.birthYear = Convert.ToInt32(Console.ReadLine());
        }

        //Змінити ім'я особи
        public void ChangeName(string newName)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            this.name = newName;
            Console.WriteLine($"Ім'я було змінено на: {newName}");
        }

        //Вивести інформацію про особу
        public void Output()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine($"Ім'я: {this.name}, Вік: {this.birthYear}");
        }

        //ToString
        public override string ToString()
        {
            return $"Ім'я: {this.name}, Вік: {this.birthYear}";
        }
        
        //Оператор (рівний за іменем)
        public static bool operator == (Person per1, Person per2)
        {
            return (per1.name == per2.name);
        }
        public static bool operator != (Person per1, Person per2)
        {
            return (per1.name != per2.name);
        }

        //Виведення інформації про осіб з однаковими іменами
        public void Comparsion(Person per1, Person per2)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            if (per1 == per2)
            {
                Console.WriteLine($"Люди з однаковими іменами та інформація про них: {per1}; {per2}");
            }
            else
            {
                Console.WriteLine($"В осіб різні імена");
            }
        }
    }
}
