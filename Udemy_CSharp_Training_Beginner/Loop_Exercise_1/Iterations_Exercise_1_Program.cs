using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Exercise_1
{
    class Iterations_Exercise_1_Program
    {
        static void Main(string[] args)
        {
            for (var i = 20; i >= 1; i--)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
