using System;

namespace Conditional_Exercise_3
{
    class Conditional_Exercise_3_Program
         //Write a program and ask the user to enter the width and height of an image.Then tell if the image is landscape or portrait
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the width of the picture");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the height of the picture");
            var height = Convert.ToInt32(Console.ReadLine());

            if (width > height)
                Console.WriteLine("Your picture orientaion is Landscape");
            else
                Console.WriteLine("Your picture orientaion is Portrait");
        }
    }
}
