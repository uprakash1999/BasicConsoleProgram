using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo
{
    internal class Fibo
    {
        public void fibo()
        {
            Console.Write("Enter a number from 0 to : ");
            int n = int.Parse(Console.ReadLine());
            int n1 = 0, n2 = 1;
            int res;
            Console.Write(n1 + " " + n2 + " ");
            for (int i = 2; i < n; i++)
            {
                res = n1 + n2;
                Console.Write(res + " ");
                n1 = n2;
                n2 = res;
            }
            Console.ReadLine();
        }
    }
}
