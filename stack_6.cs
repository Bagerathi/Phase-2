using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack(2);
            //Dynamically grow themselves
            s.Push(34);
            s.Push(34.34f);
            s.Push(34.56777d);
            s.Push(new DateTime(2019, 09, 09));
            s.Push("Hello");
            s.Push('A');
            s.Push(true);

            object a1 = s.Pop();//true
            Console.WriteLine(a1);
            a1 = s.Pop();//A
            Console.WriteLine(a1);
            a1 = s.Pop();//Hello
            Console.WriteLine(a1);
            object p = s.Peek();//returns datetime
            Console.WriteLine(p);

            int cnt = s.Count;
            bool ans = s.Contains(134);
            Console.WriteLine("Is 134 available on the stack= " + ans);
            object[] obj = s.ToArray();
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
