using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    public enum MonthsOfTheYear
    {
        Jan = 1, Feb = 2, Mar = 3, Apr = 4, May = 5, Jun = 6, Jul = 7, Aug = 8, Sep = 9, Oct = 10, Nov = 11, Dec = 12
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" \n Greetings user, please pick a number between 1 and 12: ");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput >12 || userInput < 1)
            {
                Console.Write("\n Please unter a valid number between 1 and 12: ");
                userInput = int.Parse(Console.ReadLine());
            }
            MonthsOfTheYear userMonth = (MonthsOfTheYear) userInput;
            Console.WriteLine($"\n You have selected {userMonth} as your month. \n");
        }
        
    }
}
