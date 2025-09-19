using System;

namespace Basics
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You are {age} years old.");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
