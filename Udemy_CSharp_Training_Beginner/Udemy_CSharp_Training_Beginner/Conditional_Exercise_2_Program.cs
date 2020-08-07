using System;


namespace Udemy_CSharp_Training_Beginner
{
    class Conditional_Exercise_2_Program
         //Write a program which takes two numbers from the console and displays the maximum of the two.
    {
        static void Main(string[] args)
        {
            Console.Write("Please provide the first number: ");
            var number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please provide the second number: ");
            var number2 = Convert.ToInt32(Console.ReadLine());

            var max = (number1 > number2) ? number1 : number2;

            Console.WriteLine("Max number is " + max);
        }
    }
}
