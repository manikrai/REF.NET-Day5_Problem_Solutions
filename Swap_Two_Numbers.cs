using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Problem_Solutions
{
    internal class Swap_Two_Numbers
    {
        public static void Swapping()
        {
            int First;
            Console.WriteLine("Enter First Number");
            First = Convert.ToInt32(Console.ReadLine());
            int Second;
            Console.WriteLine("Enter Second Number");
            Second= Convert.ToInt32(Console.ReadLine());
            int swap = First;
            First = Second;
            Second = swap;
           
            Console.WriteLine("After Swapping \nFirst Number Will Be:" + First);
            
            Console.WriteLine("After Swapping \nSecond Number Will Be:" + Second);

        }
    }
}
