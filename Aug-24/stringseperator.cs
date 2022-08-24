using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicOfTheApp
{
    public class stringseperator
    {
        public static void split()
        {
            string s1 = "Welcome to the world of C# Programming";
            string[] s2 = s1.Split('#');
            foreach (string s3 in s2)
            {
                Console.WriteLine(s3);
            }
        }
    }
}
