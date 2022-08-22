using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedlist_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList s = new SortedList();
            s.Add(75, "My");
            s.Add(26, "name");
            s.Add(18, "xyz");
            foreach (DictionaryEntry item in s)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }
            Console.ReadLine();
        }
    }
}
