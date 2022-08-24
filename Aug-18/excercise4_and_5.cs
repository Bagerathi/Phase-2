using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////excercise 4
            double number1, number2, number3, number4;

            Console.Write("Enter the First number: ");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            number2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the third number: ");
            number3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the fourth number: ");
            number4 = Convert.ToDouble(Console.ReadLine());

            double result = (number1 + number2 + number3 + number4) / 4;
            Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ",
         number1, number2, number3, number4, result);



            ////excersise 5

            int x, y, z;

            Console.Write("Enter the First number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number: ");
            z = Convert.ToInt32(Console.ReadLine());

            

            int result1 = ((x+y)*z) ;
            int result2 =x*y + y*z ;

            Console.WriteLine("The result is:" + result1, result2);

         



            Console.ReadLine();

        }
    }
}
