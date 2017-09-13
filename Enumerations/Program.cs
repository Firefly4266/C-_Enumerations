using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    public enum Status
    {
        New, notApproved, approved, archived
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome.  Document status include the following:  0 = New, 1 = NotApproved, 2 = Approved, 3 = Archived\n");
            Console.WriteLine(" ---------------------------------------------------------------------------------------\n");
            Console.Write(" Greetings user, please tell me the name of your document: ");
            var userInput = Console.ReadLine();
            Console.WriteLine();
            Console.Write(" Please tell me the status of your document: ");
            var secondUserInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write($" Document: {userInput}, Document Status: {(Status)secondUserInput}\n");
            Console.WriteLine();
        }
    }
}
