using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations_Exercise_4
//Write a program that picks a random number between 1 and 10. 
//Give the user 4 chances to guess the number.If the user guesses 
//the number, display “You won"; otherwise, display “You lost". 
//(To make sure the program is behaving correctly, you can display the secret number on the console first.)
{
    class Iterations_Exercise_4_Program
    {
        static void Main(string[] args)
        {
            var number = new Random().Next(1, 10);
            Console.WriteLine("The secret number is " + number);

            for (var i = 0; i<=3; i++)
            {
                Console.WriteLine("I'm thinking of a number between 1 and 10, can you guess the right answer? You only get four guesses");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("You Won!");
                    return;
                }
                    

            }

            Console.WriteLine("You Lost!");

        }
    }
}
