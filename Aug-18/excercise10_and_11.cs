using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //excercise 10 , return true if either one is negative 
            Console.WriteLine("\nInput first integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Check if one is negative and one is positive:");
            Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));
            Console.ReadLine();



            //  excercise 11 , return true if both is positive

            Console.WriteLine("\nInput first integer:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Check if both are positive:");
            Console.WriteLine((a >0 && b > 0) || (a > 0 && b > 0));
            Console.ReadLine();
        }
    }
}
