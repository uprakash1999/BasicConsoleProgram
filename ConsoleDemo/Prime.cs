using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo
{
    internal class Prime
    {
        public void prime()
        {
            Console.Write("Enter a number to check whether it is Prime or Not: ");
            int num = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (num <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

            }
            if (isPrime)
            {
                Console.WriteLine($"{num} is a Prime Number.");
            }
            else
            {
                Console.WriteLine($"{num} is not a Prime Number.");
            }
            Console.ReadLine();
        }

    }
}

