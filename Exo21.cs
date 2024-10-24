using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1IL_Sopra_Exercices
{
    public class Exo21
    {
        public void Execute()
        {
            Console.WriteLine("Tapez un mot :");
            string input = Console.ReadLine();
            bool isPalindrome = true;
            
            if (input != null) 
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] != input[input.Length - 1 - i])
                    {
                        isPalindrome = false;
                        break;
                    }
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine($"{input} est un palindrome");
            }
            else
            {
                Console.WriteLine($"{input} n'est pas un palindrome");
            }
        }
    }
}
