using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiple_if_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 0)
                Console.WriteLine("number is zero");
            else if (num % 2 == 0)
            {
                Console.WriteLine("even");
                if (num % 10 == 0)
                {
                    Console.WriteLine("{0} is a multiple of 10", num);
                }
                else
                {
                    Console.WriteLine("{0 is }not a multiple of 10", num);
                }
                if (num > 100)
                    Console.WriteLine("too large");
            }
            else
            {
                Console.WriteLine("odd");
                Console.WriteLine("{0} is not a multiple of 10", num);
                if (num > 100)
                    Console.WriteLine("out of bounds");

            }
            Console.ReadLine();
        }
    }
}
