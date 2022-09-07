using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{


    public delegate void MyDelegate();

    public delegate string Greet(string s);

    public delegate void Calculations(int a, int b);
    public delegate void ProdDelegate(Products p);
    public delegate int EmpDelegate(DateTime t);
    public delegate void CapsDelegate();

    public class Lengthstring
    {
        public void TestString()
        {
            string name = "Anthony";
            int nameLength = name.Length;
            Console.WriteLine("The name " + name + " contains " + nameLength + "letters.");
        }


        public void Concat()
        {
            string strA = "Concatenating ";
            string strB = " Two Strings ";
            string str;

            // print all strings
            Console.WriteLine("String A is: {0}", strA);
            Console.WriteLine("String B is: {0}", strB);

            // Concatenate two different strings
            // into a single String
            // using  Concat(String, String ) Method
            str = String.Concat(strA, strB);

            Console.WriteLine("Concatenated string is: {0}", str);
        }

        public string User(string name)
        {


            Console.WriteLine("hello" + name);
            return name;

        }

        public void sum(int a, int b)
        {
            Console.WriteLine("Addition of 2 nos. = {0}", a + b);
        }

        // method "subtract"
        public void subtract(int a, int b)
        {
            Console.WriteLine("Subtraction of 2 nos. = {0}", a - b);

        }


    }


    public class Products
    {
        public int PId
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public void Display(Products p)
        {
            Console.WriteLine($"Product id is {p.PId} and name is {p.Name}");
        }
    }

    public class Employee
    {
        private DateTime _joining;
        public DateTime Joining
        {
            get { return _joining; }
            set { _joining = value; }

        }
        public int Expyrs(DateTime ji)
        {
            int p = DateTime.Now.Year - ji.Year;
            return p;
        }
    }


    public class Capitalize
    {
        public void FirstCharToUpper()
        {
            string str = "delftstack";

            if (str.Length == 0)
            {
                Console.WriteLine("Empty String");
            }
            else if (str.Length == 1)
            {
                Console.WriteLine(char.ToUpper(str[0]));
            }
            else
            {
                Console.WriteLine(char.ToUpper(str[0]) + str.Substring(1));
            }
        }
    }

}


    

