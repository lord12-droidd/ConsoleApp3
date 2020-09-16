using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Привіт Донну і світ");
            string name = "Dima";
            int age = 18;
            bool isEmployed = false;
            double weight = 68.75;

            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Вес: {weight}");
            Console.WriteLine($"Работает: {isEmployed}");

            Console.WriteLine("Name: {0} Age: {1} Weight: {2} ", name, age, weight);

            Console.WriteLine($"Name: {name} Age: {age} Weight: {weight}");

            Console.ReadKey();
        }
    }
}
