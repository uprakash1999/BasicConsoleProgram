using System;

namespace ConsoleDemo
{
    internal class Armstrong
    {
        public void arms()
        {
            Console.Write("Enter a number to check whether it is an Armstrong number or not: ");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int sum = 0;
            int digits = num.ToString().Length;

            while (num > 0)
            {
                int rem = num % 10;
                sum += (int)Math.Pow(rem, digits);
                num /= 10;
            }

            if (temp == sum)
            {
                Console.WriteLine("Armstrong Number.");
            }
            else
            {
                Console.WriteLine("Not an Armstrong Number.");
            }

            Console.ReadLine();
        }
    }
}
