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
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Привіт Донну і Світ");

            Console.Write("Введіть ім'я: ");
            string name = Console.ReadLine();
            Console.Write("Введіть вік: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть ріст: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть розмір зарплатні: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Ім'я: {name}  Вік: {age}  Ріст: {height}м  Зарплата: {salary}$");

            bool isEmployed = false;
            double weight = 68.85;

            Console.WriteLine($"Ім'я: {name}");
            Console.WriteLine($"Вік: {age}");
            Console.WriteLine($"Вага: {weight}");
            Console.WriteLine($"Працює: {isEmployed}");

            Console.WriteLine("Ім'я: {0} Вік: {1} Вага: {2} ", name, age, weight);

            Console.WriteLine($"Ім'я: {name} Вік: {age} Вага: {weight}");



            Console.ReadKey();
        }
    }
}
