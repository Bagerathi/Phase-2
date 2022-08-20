using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageBasicsContd
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i = 100 , j=200;
            CallByValueExample(i,j);
            Console.WriteLine("actual value of i=" +i);
            Console.WriteLine("actual value of j= "+j);



            CallByReferenceExample(ref i, ref j);
            Console.WriteLine("calling by reference the value of i is " +i);
            Console.WriteLine("calling by reference the value of j is " +j);
            Console.WriteLine(j);


            Console.Read();



        }

        //ref means ur passing the address of values i and j not their values
        static void CallByReferenceExample(ref int i, ref int j)
        {
            int k = i;
            i = j;
            j = k;
            Console.WriteLine("swapped value of i=" + i);
            Console.WriteLine("swappd value of j =" + j);


        }


        static void CallByValueExample( int i,int j)

        {
            int k = i;
            i = j;
            j = k;
            Console.WriteLine("swapped value of i=" +i);
            Console.WriteLine("swappd value of j =" +j);

           


        }
    }
}
