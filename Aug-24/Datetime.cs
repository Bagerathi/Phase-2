using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicOfTheApp
{
    public class Datetime
    { 
        public static void displaydata()
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("Current year is: " + dt.Year);
            Console.WriteLine("Current month is:" + dt.Month);
            Console.WriteLine("current day is:" +dt.Day);
            Console.WriteLine("Current hour is: " + dt.Hour);
            Console.WriteLine( "Current minute is:" +dt.Minute);
            Console.WriteLine("Current second is :" + dt.Second);
            Console.WriteLine( "in milliseconds:" +dt.Millisecond); 

        }
    }
}
