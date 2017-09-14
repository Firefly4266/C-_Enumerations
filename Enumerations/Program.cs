using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    public enum Animals
    {
        BigDog, FurryDog, SmallDog, LongDog, BadDog, FunnyDog, AtomicDog, OldDog
    }

    public enum Places
    {
        Chicago, Seattle, Dallas, Providence, Athens, Olen, Warrensberg, Jackson
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n Greetings user, please pick a whole number between 0 and 7: ");
            var userInput = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Please pick a second whole number between 0 and 7: ");
            var userSecondInput = Convert.ToInt32(Console.ReadLine());
            //var result = (Places)input;
            Console.WriteLine($"\n Your numbers corresponds to my {(Animals)userInput} that I had while I was living in {(Places)userSecondInput}.\n");
        }
    }
}

