﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Exercise_1
//Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.Display the count on the console.
{
    class Iterations_Exercise_1_Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i%3 == 0)
                    count++;
                {
                    Console.WriteLine("There are " + count + " numbers divisible by 3 between 1 and 100.");
                }
            }
        }
    }
}
