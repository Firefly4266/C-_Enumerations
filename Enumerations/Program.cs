using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    class Program
    {
        public enum Animals
        {
            Dog, FurryDog, SmallDog, LongDog, BadDog, FunnyDog, AtomicDog, OldDog
        }
        public enum Places
        {
            Chicago, Seattle, Dallas, Providence, Athens, Olen, Warrensberg, Jackson
        }

        static void Main(string[] args)
        {
            Console.Write("Greetings user, please pick a whole number between 0 and 7: ");
            var userInput = Console.ReadLine();
            int input;
            int.TryParse(userInput, out input);
            Console.WriteLine(input);
        }
    }
}
