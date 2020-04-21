//Nathan Allen
//CSCI 1301 A
//Lab Exercise #1
//1-22-2020
//Jan 29, 2020

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Exercise_1
{
    class Program
    {
        public static void Main()
        {
            string name;
            int num1;
            int num2;

            Console.Write("Please give me your name:");
            name = Console.ReadLine();

            Console.WriteLine($"I like your name {name}\n");
            Console.WriteLine($"{name}, please enter two positive integer numbers:");
            Console.Write("Enter your first integer:");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter your second integer:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n{name}, thanks for your two numbers {num1} and {num2}");
            Console.ReadKey();

        }
    }
}
