using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marksandpercentage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grd1 ;
            double grd2 ;
            double grd3 ;
            double total;

            Console.WriteLine("Enter your first grade: ");
            grd1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second grade: ");
            grd2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your third grade: ");
            grd3 = double.Parse(Console.ReadLine());

            total= grd1 + grd2 + grd3;
            if (total >= 60)
            {
                Console.WriteLine("You are Fisrt! Your average is: " + total);
            }
            else if (total>= 45)
            {
                Console.WriteLine("Your total is: " + total);


            }
            else 
            {
                Console.WriteLine("fail");
                    
                    }
            Console.ReadLine();
        }
    }
}
