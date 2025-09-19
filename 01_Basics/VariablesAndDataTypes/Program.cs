using System;

namespace Basics
{
    class Program
    {
        static void Main()
        {
            int age = 25;
            double price = 199.99;
            string name = "Ravi";
            bool isActive = true;
            char grade = 'A';

            Console.WriteLine("=== Variables and Data Types ===");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Active: {isActive}");
            Console.WriteLine($"Grade: {grade}");

            int nextYearAge = age + 1;
            Console.WriteLine($"Next Year Age: {nextYearAge}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
