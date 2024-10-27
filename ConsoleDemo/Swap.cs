using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo
{
    internal class Swap
    {
        public void swap()
        {
            Console.WriteLine("There are two ways to swap two numbers without 3rd variabes.");
            Console.WriteLine("Choose one: ");
            Console.WriteLine("             1. using + & -");
            Console.Write("             2. using * & /");
            int choice = int.Parse(Console.ReadLine());
            switch (choice) {
                case 1:
                    int a = 5, b = 10;
                    Console.Write($"Before swaping to values: a = {a} and b = {b}");
                    a = a + b;
                    b = a - b;
                    a = a - b;
                    Console.Write($"After swaping to values: a = {a} and b = {b}");
                    break;
                case 2:
                    int x = 3, y = 6;
                    Console.Write($"Before swaping to values: a = {x} and b = {y} ");
                    x = x * y;
                    y = x / y;
                    x = x / y;
                    Console.Write($"After swaping to values: a = {x} and b = {y} ");
                    break;
                default:
                    Console.Write("Choose correct choice");
                    break;

            }
            Console.ReadLine();
        }
    }
}
