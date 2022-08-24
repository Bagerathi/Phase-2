using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an ArrayList
            ArrayList myList = new ArrayList();

            // Adding elements to ArrayList
            myList.Add("vicky");
            myList.Add("megha");
            myList.Add("bage");
            Console.WriteLine("=====Original List======");
            foreach (var item in myList)
            {
                string arrayItem = string.Format($"Name  is {item}");
                Console.WriteLine(arrayItem);
            }
            Console.WriteLine("Count : " + myList.Count);  //count


            //Removing items from the list
            myList.Remove("bage");
            Console.WriteLine("=====Modified List======");
            for (int i = 0; i < myList.Count; i++)
            {
                string arrayItem = string.Format($"Name  is {myList[i]}");
                Console.WriteLine(arrayItem);
            }
            Console.WriteLine("Count : " + myList.Count);  //count
            Console.ReadLine();
        }
    }
}
