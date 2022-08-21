using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace null_empty_string_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            string str1 = string.Empty;
            string str2;
            Console.WriteLine("enter first number :");
            string a=Console.ReadLine();
            Console.WriteLine("enter second number: ");
            string b = Console.ReadLine();
            bool b1 = String.IsNullOrEmpty(a);
            Console.WriteLine(b1);
            bool b2 = String.IsNullOrEmpty(b);
            Console.WriteLine(b2);
            Console.ReadLine();



        }
    }
}
