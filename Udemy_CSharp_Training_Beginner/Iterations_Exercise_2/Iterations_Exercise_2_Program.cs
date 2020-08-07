using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations_Exercise_2
    //Write a program and continuously ask the user to enter a number or "ok" to exit.
    //Calculate the sum of all the previously entered numbers and display it on the console.
{
    class Iterations_Exercise_2_Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            while (true)
            {
                Console.Write("Please enter a number. Or if you do not to participate enter 'Quit': ");
                var input = (Console.ReadLine());

                if (input.ToLower() == "quit")
                    break;

                sum += Convert.ToInt32(input);
            }
            {
                Console.WriteLine("The sum for all the entries is " + sum);
            }


        }
    }
}
