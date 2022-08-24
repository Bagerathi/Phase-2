using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicOfTheApp;

namespace filehandling_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SampleClass.Hello();

            DifferentFileMethods.MakeFile();


            string s =Console.ReadLine();
            UnderstandingStrings.StringLength(s);

               
            stringequals.stringequal();

            copystring.createcopy();

            indexof.createindex();


            stringseperator.split();



            Console.WriteLine("===================");
            Console.WriteLine("enter to convert to upper");
            string s1=Console.ReadLine();

            uppercase.createupper(s1);


            Console.WriteLine("====================");
            blanktextfile.createfile();
            Console.WriteLine("Textfile created");

            Console.WriteLine("=======================");
            Datetime.displaydata();












            Console.ReadLine();
        }
    }
}
