using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise_13
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            ///////excercise 13 
            
            double number;
            Console.WriteLine(" enter the number in meters :");
            number = Convert.ToDouble(Console.ReadLine());
            double  km = number / 1000;
            Console.WriteLine("the answer in kilometers is :" +km );
            


            ////excercise 14
            
            double celsius,fahrenheit ;
            Console.Write("Enter the temperature value in Celsius: ");
            celsius = Convert.ToDouble(Console.ReadLine());
            fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("The temperature in Fahrenheit is {0}", +fahrenheit);
           

            ///// excercise 15
            ///
         

            int Dolval;
            Console.WriteLine(" enter the value in dollars :");
            Dolval = Convert.ToInt32(Console.ReadLine());
            int Indval = Dolval / 80;
            Console.WriteLine("the value in indian currency for an US Dollar is :" +Indval);

            Console.Read();






        }
    }
}
