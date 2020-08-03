using System;

namespace Exercise_3
{
    class Ex_3_Program
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
