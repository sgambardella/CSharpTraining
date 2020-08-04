using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Exercise_3
{
    class Conditional_Exercise_3_Program
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
