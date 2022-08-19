using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxminnumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////progra to find max and min numbers
            int a;
            int b;
            int min;
            int max;

            //input numbers
            Console.Write("Enter first number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            //finding max number using if-else
            if (a > b)
                max = a;
            else
                max = b;

            //finding min number using if else
            if (a < b)
                min = a;
            else
                min = b;

            //printing
            Console.WriteLine("Using if-else...");
            Console.WriteLine("Minimum number = {0}", min);
            Console.WriteLine("Maximum number = {0}", max);

            Console.ReadLine();
        }
    }
}
