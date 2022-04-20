using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Problem_Solutions
{
    internal class Vowel_Or_Consonant
    {
        public static void Check()
        {
            char ch;
            Console.WriteLine("Enter your Alphabet To Check Its Vowel Or Consonants");
            Console.WriteLine();
            ch = Convert.ToChar(Console.ReadLine().ToLower());
            int i = ch;
            if(i>=48 && i<=57)
            {
                Console.WriteLine("You Entered A number ,Please Enter Alphabet");
            }
            else
            {
                switch(ch)
                {
                    case 'A':
                        Console.WriteLine("The Alphabet Is Vowel");
                        break;
                    case 'E':
                        Console.WriteLine("The Alphabet Is Vowel");
                        break ;
                    case 'I':
                        Console.WriteLine("The Alphabet Is Vowel");
                        break;
                    case 'O':
                        Console.WriteLine("The Alphabet Is Vowel");
                        break;
                    case 'U':
                        Console.WriteLine("The Alphabet Is Vowel");
                        break;
                    default: 
                        Console.WriteLine("The Alphabet is Consonant");
                        break;
                        



                }
                
            }
            Console.ReadKey();
        }
    }
}
