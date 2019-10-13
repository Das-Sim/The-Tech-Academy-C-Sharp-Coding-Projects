using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants_Practice_1
{
    class Class1
    {
        // 3. Chain two constructors together.
        public Class1(string skill) : this(50, skill)
        {

        }
        public Class1(int points, string name)
        {
            Points = points;
            Class = name;
           
        }
        public int Points { get; set; }
        public string Class { get; set; }
    }
}
