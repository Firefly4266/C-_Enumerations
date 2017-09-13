using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    class Program
    {
        public enum MonthsOfTheYear
        {
            Jan = 1, Feb = 2, Mar = 3, Apr = 4, May = 5, Jun = 6, Jul = 7, Aug = 8, Sept = 9, Oct = 10, Nov = 11, Dec =12 
        }
        static void Main(string[] args)
        {
            Console.Write(" Greeting user, please enter a number between 1 and 12: ");
            var userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (userInput < 1 || userInput > 12)
            {
                Console.Write("Please enter a valid numeric entry between 1 and 12: ");
                userInput = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            var num = (MonthsOfTheYear)userInput;
            Console.WriteLine($" {num} is the month that correspondes to the number you selected.\n");
        }
    }
}
