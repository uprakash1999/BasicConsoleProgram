using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo
{
    internal class Palindrome
    {
        public void palindrome()
        {
            int rem, sum = 0, temp;
            Console.Write("Enter a number to check whether it is Palindrome or not: ");
            int n = int.Parse(Console.ReadLine());
            temp = n;
            while (n>0) {
                rem = n % 10;
                sum = (sum * 10) + rem;
                n = n / 10;
            }
            if(temp == sum)
            {
                Console.WriteLine($"{temp} Number is palindrome.");
            }
            else
            {
                Console.WriteLine($"{temp} Number is not palindrome.");
            }
        }
    }
}
