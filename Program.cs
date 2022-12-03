using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторна_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Натиснiть будь-яку кнопку, для того, щоб вивести данi на екран");
            Console.ReadKey();

            //Person
            Person per1 = new Person("Eliza", 2004);
            Person per2 = new Person("Inna", 1978);
            Person per3 = new Person("Maks", 2019);
            Person per4 = new Person("Eliza", 1995);
            Person per5 = new Person("Olexandr", 2001);
            Person per6 = new Person("Anastasia", 2008);

            per1.Age();
            per2.Age();
            per3.Age();
            per4.Age();
            per5.Age();
            per6.Age();

            per1.Output();
            per2.Output();
            per3.Output();
            per4.Output();
            per5.Output();
            per6.Output();

            per3.ChangeName("Very Young");
            per3.Output();

            per6.ChangeName("Very Young");
            per6.Output();

            Console.WriteLine($"Інформація про всіх: {per1}; {per2}; {per3}; {per4}; {per5}; {per6}");

            per1.Comparsion(per1, per4);
            per1.Comparsion(per1, per6);

            Console.WriteLine("Натисніть будь-яку кнопку, для того, щоб закрити консоль");
            Console.ReadKey();
        }
    }
}
