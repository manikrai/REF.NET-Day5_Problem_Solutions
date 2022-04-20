using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Problem_Solutions
{
    internal class Even_Odd
    {
        public static void Evenodd()
        {
            int i = 0;
            Console.WriteLine("Enter your value to Check your value is Even Or Odd");
            i=Convert.ToInt32(Console.ReadLine());
           // for (i = 0; i <= 10; i++)
            //{
                if(i %2== 0)
                {
                    Console.WriteLine("even");
                   // Console.WriteLine("Even no: " +i);
                }
            //}
            Console.WriteLine();
            //for (i = 0; i <= 10; i++)
            //{
                if (i %2!= 0)
                {
                    Console.WriteLine("Odd");
                   // Console.WriteLine("odd no: " + i);
                }
            //}
        }  

    }
}
