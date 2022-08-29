using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studentsLibrary;


namespace datastructures_array
{
    internal class studentslistprogram3
    {
        static void Main(string[] args)
        {
            List<Studentdetails> students = new List<Studentdetails>();
            {
                new Studentdetails() { group = "Bio", marks = 42 };
                new Studentdetails() { group = "Commerce", marks = 34 };
               };

            for (int i = 0; i < Studentdetails.len; i++)
            {
                Console.WriteLine(Studentdetails[i].Name + " is " + Studentdetails[i].Age + " years old");
            }


        }
    }
}
