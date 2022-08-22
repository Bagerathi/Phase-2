using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Vicky");
            dict.Add(2, "Megha");
            dict.Add(3, "Guru");
            Console.WriteLine("Values in Dictionary are: \n");
            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine(item.Key + "  " + item.Value);

            }
            Console.ReadKey();
        }
    }
}
