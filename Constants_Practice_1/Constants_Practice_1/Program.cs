using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants_Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Job = "Builder"; //1.Create a const variable
            Class1 Class = new Class1("Class");
            var var1 = Class.Points; //2. Create a variable using the keyword "var".
            Console.WriteLine("Skill Points are {0} for {1}.", var1, Job);
            Console.Read();

        }       
    }
}
