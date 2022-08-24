using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biggestintwonubers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = 50;
            int num2 = 90;
            int maxNum;
            Console.WriteLine("Number 1: " + num1);
            Console.WriteLine("Number 2: " + num2);
            if (num1 > num2)
            {
                maxNum = num1;
            }
            else
            {
                maxNum = num2;
            }
            Console.WriteLine(" Biggest number is: " + maxNum);
            Console.ReadKey();
        }
    }
}
