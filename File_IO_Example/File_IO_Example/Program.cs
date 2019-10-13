using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_IO_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.\n"); //1. Ask a user for a number.
            int num = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\spuns\Documents\blank.txt"))
            {
                file.WriteLine(num); //2. Log that number to a text file.
                file.Close();
                string file1 = File.ReadAllText(@"C:\Users\spuns\Documents\blank.txt");
                Console.WriteLine("Your number is " + file1); //3. Print the text file back to the user.
            }
            Console.ReadLine();
        }
    }
}
