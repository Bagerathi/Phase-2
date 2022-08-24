using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicOfTheApp
{
    public class indexof
    { 
        public static void createindex()
        {
            string str = "Demon Slayer";

            // Finding the index of character
            // which is present in string and
            // this will show the value 5
            int index1 = str.IndexOf('m');

            Console.WriteLine("The Index Value of character 'm' is " + index1);

            // Now finding the index of that character which
            //  is not even present with the string
            int index2 = str.IndexOf('z');

            // As expected, this will output value -1
            Console.WriteLine("The Index Value of character 'C' is " + index2);
        }
    }
}
