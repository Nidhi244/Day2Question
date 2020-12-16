using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int num, i, count = 0, min, max;
            Console.WriteLine("Enter the first number");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            max = Convert.ToInt32(Console.ReadLine());

            Console.Write("The prime numbers between {0} and {1} are : \n", min, max);
            for (num = min; num <= max; num++)
            {
                count = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                        break;
                    }
                }

                if (count == 0 && num != 1)
                    Console.Write("{0} ", num);
                //Console.ReadKey();
            }
            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
