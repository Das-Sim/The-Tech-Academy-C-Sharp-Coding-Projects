using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant_Constructors_Practice
{
    public class Employee
    {
        public Employee(string name, string city)
        {
            const string eName = "Joe Bob"; //1.Create a const variable

            var Company = "Regal's Construction"; //2.Create a variable using the keyword "var".

            Console.WriteLine("\n New Hire: {0} \n Hiring Company: {1}", eName, Company); //3. Chain two constructors together.
        }
        public Employee()
        {
            
        }
    }
}
