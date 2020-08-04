using System;

namespace Conditional_Exercise_4
{
    class Conditional_Ex_4_Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the speed of the car: ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());
                       
            if (carSpeed <= speedLimit)
                  Console.WriteLine("Safe Speed");

            else
            {
                const int demeritBlocks = 2;
                var demeritPoints = (carSpeed - speedLimit) / demeritBlocks;

                if (demeritPoints >= 10)
                    Console.WriteLine("Your licsense is suspended!!!!!!!!!!!");

                else
                    Console.WriteLine("You have " + demeritPoints + " demerits");
            }



        }
    }
}
