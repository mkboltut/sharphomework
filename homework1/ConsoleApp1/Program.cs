using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string family = Console.ReadLine();
            Console.Write("Введите возраст: ");
            string age = Console.ReadLine();
            Console.Write("Введите рост: ");
            string height = Console.ReadLine();
            Console.Write("Введите вес: ");
            string weight = Console.ReadLine();
            /*Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст,
            рост, вес). В результате вся информация выводится в одну строчку:*/
            Console.WriteLine("\n" + name +  " " + family + ", ваш возраст " + age + ", ваш рост " + height + ", ваш вес " + weight);
            Console.WriteLine($"\n{name} {family}, ваш возраст {age}, ваш рост {height}, ваш вес {weight},");
            Console.WriteLine("\n{0} {1}, ваш возраст {2}, ваш рост {3}, ваш вес {4},", name, family, age, height, weight);

            /* Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле
             I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах. Будем использовать уже введенные данные */

            float h = float.Parse(height)/100;
            int w = int.Parse(weight);
            float indexMass = w/(h*h);
            Console.WriteLine("\nИндекс массы тела равен: {0}", indexMass);

            int a = 3;
            int b = 5;
            (a, b ) = (b, a);
            Console.WriteLine("переменная a: " + a);
            Console.WriteLine("переменная b: " + b);

            int z = 8;
            int x = 2;
            int y;
            y = x;
            x = z;
            z = y;

            Console.WriteLine("переменная z: " + z);
            Console.WriteLine("переменная x: " + x);

            Console.ReadLine();

        }
    }
}
