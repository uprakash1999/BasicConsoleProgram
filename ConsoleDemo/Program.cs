using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool continueProgram = true;

            while (continueProgram)
            {
                Console.Clear();
                Console.WriteLine("1. Fibonacci Series");
                Console.WriteLine("2. Prime Numbers");
                Console.WriteLine("3. Palindrome");
                Console.WriteLine("4. Factorial Numbers");
                Console.WriteLine("5. Armstrong Numbers");
                Console.WriteLine("6. Sum Of Digits");
                Console.WriteLine("7. Swapping two numbers without using a third variable");
                Console.WriteLine("8. Binary to Decimal Conversion");
                Console.WriteLine("9. Numbers to Char conversion");
                Console.WriteLine("---------- Choose a program ----------");
                Console.Write("Your choice: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Fibo f = new Fibo();
                            f.fibo();
                            break;
                        case 2:
                            Prime p = new Prime();
                            p.prime();
                            break;
                        case 3:
                            Palindrome pa = new Palindrome();
                            pa.palindrome();
                            break;
                        case 4:
                            Factorial fa = new Factorial();
                            fa.fact();
                            break;
                        case 5:
                            Armstrong a = new Armstrong();
                            a.arms();
                            break;
                        case 6:
                            SumOfDigits s = new SumOfDigits();
                            s.sum();
                            break;
                        case 7:
                            Swap sw = new Swap();
                            sw.swap();
                            break;
                        case 8:
                            DecimalToBinary d = new DecimalToBinary();
                            d.d2b();
                            break;
                        case 9:
                            ConvertNumbersToChar c = new ConvertNumbersToChar();
                            c.convert();
                            break;
                        default:
                            Console.WriteLine("Invalid Choice!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                }

                Console.WriteLine("\nDo you want to run another program? (y/n): ");
                continueProgram = Console.ReadLine()?.ToLower() == "y";
            }

            Console.WriteLine("Program exited.");
        }
    }
}
