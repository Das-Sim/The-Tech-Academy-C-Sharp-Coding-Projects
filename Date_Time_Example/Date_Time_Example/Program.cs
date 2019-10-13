using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(1995, 5, 23, 8, 32, 45);
            Console.WriteLine("Today's date and time is: " + dateTime); //1.Prints the current date and time to the console.
            Console.WriteLine("Enter a number 0-24."); //2.Asks the user for a number.
            int hour = Convert.ToInt32(Console.ReadLine());
            DateTime futureTime = dateTime.AddHours(hour);
            Console.WriteLine("After {0} hours, time will be: {1}", hour, futureTime); //3.Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
            Console.WriteLine("Thank you for viewing my program. Have a good day.");
            Console.ReadLine();
        }
    }
}
