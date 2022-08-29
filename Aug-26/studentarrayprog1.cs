using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;
using studentsLibrary;


namespace datastructures_array
{
    internal class studentarrayprog1
    {
        static void Main(string[] args)
        {
           
            Student[] stud = { new Student(),
                       new Student(),
                       new Student() };

            
            stud[0].SetStudent(1, "vicky", 20);
            stud[1].SetStudent(2, "Sam", 21);
            stud[2].SetStudent(3, "JO", 23);

            // Call the display method
            stud[0].DisplayStudent();
            stud[1].DisplayStudent();
            stud[2].DisplayStudent();

            Console.ReadLine();

        }

        
    }
}
