using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashtable_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a hashtable
            // Using Hashtable class
            Hashtable my_hashtable1 = new Hashtable();

            // Adding key/value pair
            // in the hashtable
            // Using Add() method
            my_hashtable1.Add("A1", "1");
            my_hashtable1.Add("A2", "2");
            my_hashtable1.Add("A3", "3");

            Console.WriteLine("Key and Value pairs from my_hashtable1:");

            foreach (DictionaryEntry ele1 in my_hashtable1)
            {
                Console.WriteLine("{0} and {1} ", ele1.Key, ele1.Value);
            }

            Console.WriteLine("The elements presesnt are " +"in my_hashtable1:{0}","11,12,13" );
            my_hashtable1.Remove("A2");
            Console.WriteLine("Elements present after removing " + "my_hashtable1:{0}", "11,13");
            Console.ReadLine();
            
        }
    }
}
