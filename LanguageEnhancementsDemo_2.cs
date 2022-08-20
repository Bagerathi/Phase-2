    using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace LanguageEnhancementsDemo
{
    internal class Program
    {
        static void Main(string[] args)

        {

            //keywords,typeconversion,parsing,Tryparse and more in C#


            int num1, num2, num3;

            Console.Write("Input the first number to multiply: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number to multiply: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the third number to multiply: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            int result = num1 * num2 * num3;
            Console.WriteLine("Output: {0} x {1} x {2} = {3}",
                                num1, num2, num3, result);



            int x, int z;
            Console.Write("Input the first number : ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number : ");
            z = Convert.ToInt32(Console.ReadLine());





            Console.ReadLine();




            // Console.WriteLine("Menu \n 1. Square root\n 2. square \n3.Cube \n 4.Exit"







            // #region IntroductionToVarandDynamicTypes
            // var i = "hello";
            // var j = 77; // implicitly casting to the data assigned to it
            //// j = "some string"; // not allowed ,cant assign string to j which is declared  of int type


            //     float pi = 3.14f;
            // char c = 'A';
            // DateTime dt;
            // double d1;

            // ConsoleColor color = ConsoleColor.Green; // this is an enum



            // object o = 88;
            // int v = (int)o; //called explicit casting

            // dynamic p = "hi";
            // p = 4555; // with dynamic , u can assign it to int after declaaring with string



            // // only value types can be boxed
            // object obj1 = 74444;

            // int j1 = 1000;
            // object obj = j1; //object is bigger than int datatype , so it can be boxed
            // float g = j1; //allowed both of same type struct

            // int k = (int)obj; //this is called unboxing 
            //                   // bringing a datatype back to its original datatype


            // #endregion
















        }
    }
}
