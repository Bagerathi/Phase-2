using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Enter Numbers");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            int a;
            addition(n1, n2);

            Console.ReadLine();
        }
        static void addition(int a, int b)
        {
            Console.WriteLine("Sum={0}", a + b);

        }
    }
    
}
