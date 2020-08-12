using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Notes
{
    class Lists_Notes_Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() {1, 2, 3, 4 };
            //Adding the number "1" to the end of the list
            numbers.Add(1);
          
            //Adding an array of integers to the end of the list
            numbers.AddRange(new int[3] { 5, 6, 7 });
            
            //Displaying the numbers in the list vertically
            foreach (var number in numbers)
                Console.WriteLine(number);

            //Idex position of "1"
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            
            //Last index of "1"
            Console.WriteLine("Index of 1: " + numbers.LastIndexOf(1));

            //Quantity of number in the list
            Console.WriteLine("Count: " + numbers.Count);

            //Removing specific numbers in a list
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }
            foreach (var number in numbers)
                Console.WriteLine(number);

            //Clearing numbers in a list
            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);

        }
    }
}
