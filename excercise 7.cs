using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x;
            Console.Write("Enter the number ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0} {0} {0} {0}\n {0}{0}{0}{0} \n {0} {0} {0} {0} \n {0}{0}{0}{0} ", x);
           

            int y;
            Console.Write("\n Enter the number ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}{0}{0} \n{0} {0} \n{0} {0} \n{0} {0} \n{0}{0}{0}" ,y);
            Console.Read();
        }
    }
}
