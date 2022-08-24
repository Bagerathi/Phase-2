using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.Zero \n 2.Even/odd \n 3.multiple of 10 \n 4.out of bounds \n");
            int ch = 0;
            while (ch < 4)
            {
                switch (ch)
                {
                    case 0:
                        if (num == 0)
                            Console.WriteLine("number is zero");
                        break;
                    case 1:
                        if (num % 2 == 0)
                        {
                            Console.WriteLine("{0} is even", num);
                        }
                        else
                            Console.WriteLine("{0} is odd", num);

                        break;
                    case 2:
                        if (num % 10 != 0)
                        {
                            Console.WriteLine("{0} is not a multiple of 10", num);

                        }
                        else
                        {
                            Console.WriteLine("{0} is a multiple of 10", num);

                        }
                        break;
                    case 3:
                        if (num > 100)
                            Console.WriteLine("out of bounds");
                        break;
                    default:
                        break;



                }
                ch++;
            }
            Console.ReadLine();
        }
    }
}
