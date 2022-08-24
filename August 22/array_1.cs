using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\nElements in array are: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            
            Console.ReadLine();

        }
    }
}
