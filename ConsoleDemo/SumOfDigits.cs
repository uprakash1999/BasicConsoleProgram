using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo
{
    internal class SumOfDigits
    {
        public void sum()
        {
            int rem, sum=0;
            Console.Write("Enter a number digits to find the sum: ");
            int num = int.Parse(Console.ReadLine());
            while (num > 0) {
                rem = num % 10;
                sum += rem;
                num = num / 10;
            }
            Console.Write("Sum is: " + sum);
            Console.ReadLine();
        }
    }
}
