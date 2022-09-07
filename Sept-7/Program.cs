using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;


namespace sept7_handson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lengthstring s1 = new Lengthstring();
            MyDelegate del = new MyDelegate(s1.TestString);
            del.Invoke();


            Console.WriteLine("================");
            Console.WriteLine(  "Question 2");
            Greet g1 = new Greet(s1.User);
            g1("anitha");


            Console.WriteLine("===============================");
            Console.WriteLine("Question 3");
            Calculations cal1 = new Calculations(s1.sum);
            Calculations cal2 = new Calculations(s1.subtract);
            Calculations cal =(Calculations) MulticastDelegate.Combine(cal1, cal2);

            cal( 10,6);

            Console.WriteLine("=====================================");
            Console.WriteLine("Question 6");
            MyDelegate cct = new MyDelegate(s1.Concat);
            cct();


            Console.WriteLine("========================================");
            Console.WriteLine("Question 4");
            Console.WriteLine("Enter productId and product name");
            Products p1 = new Products();
            p1.PId = Convert.ToInt32(Console.ReadLine());
            p1.Name = Console.ReadLine();
            ProdDelegate poi = new ProdDelegate(p1.Display);
            poi(p1);


            Console.WriteLine("=============================================");
            Console.WriteLine("Question 5");
            Console.WriteLine("Enter the year,Month,date");
            int yr = Convert.ToInt32(Console.ReadLine());
            int mon = Convert.ToInt32(Console.ReadLine());
            int dt = Convert.ToInt32(Console.ReadLine());
            Employee emp = new Employee();
            DateTime t = new DateTime(yr, mon, dt);
            emp.Joining = t;
            EmpDelegate e1 = new EmpDelegate(emp.Expyrs);
            int yrs= e1(emp.Joining);
            Console.WriteLine($"Years of exp {yrs}");

            Console.WriteLine("=================================================");
            Console.WriteLine("Question 7");
            Capitalize cap=new Capitalize();
            CapsDelegate c = new CapsDelegate(cap.FirstCharToUpper);
            c();






            Console.ReadKey();
        }
    }
}
