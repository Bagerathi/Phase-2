using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius, kelvin, fahrenheit;
            Console.Write("Enter the amount of Celsius: ");
            celsius = Convert.ToDouble(Console.ReadLine());
            kelvin = celsius + 273;
            fahrenheit = celsius * 18 / 10 + 32;
            Console.WriteLine("Kelvin = {0}K",+kelvin);
            Console.WriteLine("Fahrenheit = {0}F",+fahrenheit);
            Console.Read();

        }

    }
    
}
