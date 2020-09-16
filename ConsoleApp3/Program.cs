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
            Console.WriteLine("Привіт Донну і Світ");
            string name = "Dima";
            int age = 18;
            bool isemployed = false;
            double weight = 68.75;

            Console.WriteLine($"имя: {name}");
            Console.WriteLine($"возраст: {age}");
            Console.WriteLine($"вес: {weight}");
            Console.WriteLine($"работает: {isemployed}");

            Console.WriteLine("Name: {0} Age: {1} Weight: {2} ", name, age, weight);

            Console.WriteLine($"Name: {name} Age: {age} Weight: {weight}");

            Console.Write("Введите имя: ");
            string name1 = Console.ReadLine();
            Console.Write("Введите возраст: ");
            int age1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите рост: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите размер зарплаты: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Имя: {name1}  Возраст: {age1}  Рост: {height}м  Зарплата: {salary}$");

            Console.ReadKey();
        }
    }
}
