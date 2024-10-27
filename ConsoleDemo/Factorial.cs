using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo
{
    internal class Factorial
    {
        public void fact()
        {
            int fact = 1;
            Console.Write("Enter any number to find its factorial: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine();
            Console.WriteLine("Factorial of"+num+" is: "+fact);
            Console.ReadLine();
        }
    }
}
