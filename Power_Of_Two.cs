﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Problem_Solutions
{
    internal class Power_Of_Two
    {
        public static void power()
        {
            int i, number;
            
            Console.WriteLine("Input The Number: ");
            number =Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=10;i++)
            {
                Console.Write("{0}X{1}={2} \n", number, i, number * i);
            }
        }
    }
}
