using studentsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace datastructures_array
{
    internal class Studentarrayprogram2
    {
        static void Main(string[] args)
        {
           Studentdetails[] s = new Studentdetails [2];

            s[0] = new Studentdetails();
            s[1] = new Studentdetails();
            //reading and printing first object
            s[0].SetInfo("Vicky ", 1, 22);
            s[0].printInfo();
            //reading and printing second object
            s[1].SetInfo("megha", 2, 22);
            s[1].printInfo();

            Console.ReadLine();



        }
    }
}
