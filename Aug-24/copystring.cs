using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicOfTheApp
{
    public class copystring
    {
        public static  void createcopy()
        {
            string s1 = "Hello ";
            string s2 = string.Copy(s1);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
