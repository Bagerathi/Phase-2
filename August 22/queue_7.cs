using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue my_queue = new Queue();

            // Adding elements in Queue
            // Using Enqueue() method
            my_queue.Enqueue(1);
            my_queue.Enqueue(2);
            my_queue.Enqueue(3);
            my_queue.Enqueue(4);
            my_queue.Enqueue(5);
            my_queue.Enqueue(6);

            // Accessing the elements
            // of my_queue Queue
            // Using foreach loop
            foreach (var ele in my_queue)
            {
                Console.WriteLine(ele);
            }
            Console.WriteLine("Total elements present in my_queue: {0}",
                                                    my_queue.Count);
            ///using Dequeue method 
            my_queue.Dequeue();
            foreach (var ele in my_queue)
            {
                Console.WriteLine(ele);
            }
            Console.WriteLine("Total elements present in my_queue: {0}",
                                                    my_queue.Count);


          /// to find topmost element , use peek method

            Console.WriteLine("Topmost element of my_queue is: {0}",
                                              my_queue.Peek());

            Console.WriteLine("Total elements present in my_queue: {0}",
                                                        my_queue.Count);


            Console.ReadLine();


        }
    }
}
