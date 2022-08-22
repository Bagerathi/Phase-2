using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaggedarray_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare the array of four elements:  
            int[][] jaggedArray = new int[2][];
            // Initialize the elements:  
            jaggedArray[0] = new int[] { 55,50,48 };
            jaggedArray[1] = new int[] { 50, 45, 48 };
            
            // Display the array elements:  
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                System.Console.Write("Classroom number ({0}) \t: ", i + 1 );
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    System.Console.Write(jaggedArray[i][j] + "\t");
                }
                System.Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
