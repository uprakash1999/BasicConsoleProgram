using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo
{
    internal class ConvertNumbersToChar
    {
        public void convert()
        {
            Console.Write("Enter the Number: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0, rem;
            while (n > 0) {
                rem = n % 10;
                sum = sum * 10 + rem;
                n = n / 10;
            }
            n = sum;
            while (n > 0)
            {
                rem = n % 10;
                switch (rem)
                {
                    case 0:
                        Console.Write("Zero ");
                        break;
                    case 1:
                        Console.Write("One ");
                        break;
                    case 2:
                        Console.Write("Two ");
                        break;
                    case 3:
                        Console.Write("Three ");
                        break;
                    case 4:
                        Console.Write("Four ");
                        break;
                    case 5:
                        Console.Write("Five ");
                        break;
                    case 6:
                        Console.Write("Six ");
                        break;
                    case 7:
                        Console.Write("Seven ");
                        break;
                    case 8:
                        Console.Write("Eight ");
                        break;
                    case 9:
                        Console.Write("Nine ");
                        break;
                    default:
                        Console.Write("Enter valid numbers");
                        break;
                }
                n = n / 10;
            }
            Console.ReadLine();
        }
    }
}
