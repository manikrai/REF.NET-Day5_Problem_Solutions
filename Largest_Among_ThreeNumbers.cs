using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Problem_Solutions
{
    internal class Largest_Among_ThreeNumbers
    {
        public static void Max()
        {
            int Number1;
            Console.WriteLine("Enter First Number");
            Number1 = Convert.ToInt32(Console.ReadLine());
            int Number2;
            Console.WriteLine("\nEnter Second Number");
            Number2 = Convert.ToInt32(Console.ReadLine());
            int Number3;
            Console.WriteLine("\nEnter Third Number");
            Number3 = Convert.ToInt32(Console.ReadLine());

            if(Number1 == Number2 && Number1 == Number3 && Number2 == Number1 && Number2 == Number3 && Number3 == Number1 && Number3 == Number2)
            {
                Console.WriteLine("All the Numbers Are Same");
            }
            else if(Number1>Number2 && Number1>Number3 )
            {
                Console.WriteLine("First Number is Largest: " + Number1);
            }
            else if(Number2>Number1 && Number2>Number3 )
            {
                Console.WriteLine("Second Number is Largest: " + Number2);
            }
            else if(Number3>Number2 && Number3>Number1 )
            {
                Console.WriteLine("Third Number is Largest: " + Number3);
            }
        }
    }
}
