using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo
{
    internal class Reverse
    {
        public void reverse()
        {
            Console.Write("Enter a number to reverse it: ");
            int num = int.Parse(Console.ReadLine());
            int rem, rev = 0;
            while (num != 0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }
            Console.Write($"Reversed numbers of {num} is: {rev}");
            Console.ReadLine();
        }
    }
}
