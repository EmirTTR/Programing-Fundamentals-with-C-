﻿using System;

namespace _01._Smallest_of_Three_num1s
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
          
            SmollestNum(num1, num2, num3);
        }

        static void SmollestNum(int num1, int num2, int num3)
        {
            if (num1 <= num2 && num1 <= num3)
            {
                Console.WriteLine(num1);
            }
            else if (num2 <= num1 && num2 <= num3)
            {
                Console.WriteLine(num2);

            }
            else
            {
                Console.WriteLine(num3);

            }
        }
    }
}
