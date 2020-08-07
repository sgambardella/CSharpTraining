using System;

namespace Conditional_Exercise_4
{
    class Conditional_Exercise_4_Program
        //Your job is to write a program for a speed camera.For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
        //Write a program that asks the user to enter the speed limit.Once set, the program asks for the speed of a car.If the user enters a value less than 
        //the speed limit, program should display Ok on the console.If the value is above the speed limit, the program should calculate the number of demerit 
        //points.For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. If the number of demerit points is 
        //above 12, the program should display License Suspended.
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
