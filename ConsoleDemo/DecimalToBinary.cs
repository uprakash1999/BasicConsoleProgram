﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo
{
    internal class DecimalToBinary
    {
        public void d2b()
        {
            int i;
            int[] a = new int[10];
            Console.Write("Enter the number to convert: ");
            int n = int.Parse(Console.ReadLine());
            for(i = 0; n > 0; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            Console.Write("Binary of given numbers: ");
            for(i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
            Console.ReadLine();
        }
    }
}
