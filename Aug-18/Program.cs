using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


        {
           
            {

                string nullStr = null;
                // print True
                Console.WriteLine(String.IsNullOrEmpty(nullStr));

                string emptyStr1 = "";
                // print True
                Console.WriteLine(String.IsNullOrEmpty(emptyStr1));

                string emptyStr2 = String.Empty;
                // print True
                Console.WriteLine(String.IsNullOrEmpty(emptyStr2));

                string str = "some text";
                // print False
                Console.WriteLine(String.IsNullOrEmpty(str));
                    Console.Read();


            }
        }

    }
    }
}
