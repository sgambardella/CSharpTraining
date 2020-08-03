using System;

namespace Exercise2
{
     class Ex_2_Program
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
