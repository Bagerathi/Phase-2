using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int n, i, j, tmp;


            Console.Write("\n\nFind sum of all elements of array:\n");
            Console.Write("--------------------------------------\n");
            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Input the elements in the array :\n", n); 
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (a[i] < a[j])
                    {
                        tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }
                }
            }

            Console.Write("\nElements of array is sorted in descending order:\n");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
                
            }
            Console.ReadLine();

        }
    }
    
}
