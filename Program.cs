using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Printing the current date and time to the console
            Console.WriteLine("The current time is: " + DateTime.Now);
            // Asking the user for a number
            Console.WriteLine("\nPlease type a number to see the time will be in that many hours: ");
            float number = float.Parse(Console.ReadLine());
            // Printing the time it will be in the amount of hours the user input
            Console.WriteLine("{0} + {1} hour(s) = {2}", DateTime.Now, number, DateTime.Now.AddHours(number));
            // Keeping the console open until the user has pressed a key
            Console.ReadLine();
        }
    }
}
