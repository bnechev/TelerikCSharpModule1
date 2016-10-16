using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanVariable
{
    class BooleanVariable
    {
        static void Main(string[] args)
        {
            string gender = "Male";
            bool isFemale = (gender == "Female");
            Console.WriteLine("Is it my gender female: " + isFemale);
        }
    }
}
