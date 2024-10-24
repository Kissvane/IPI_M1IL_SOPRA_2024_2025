using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1IL_Sopra_Exercices
{
    public class Exo19
    {
        public void Execute()
        {
            Console.WriteLine("Tapez un mot :");
            string input = Console.ReadLine();
            char[] result = new char[input.Length];
            int index = 0;
            foreach (char c in input)
            {
                result[index] = c;
                Console.WriteLine(result[index]);
                index++;
                if (index < input.Length) 
                {
                    Console.WriteLine(".");
                }
            }

            Console.WriteLine("-----");

            for (int i = 0; i < input.Length; i++)
            {
                //swap element only if i is below he midle of the array
                //too prevent double inverting
                if (i < input.Length/2) 
                {
                    char temp = result[input.Length - 1 - i];
                    result[input.Length - 1 - i] = result[i];
                    result[i] = temp;
                }
                Console.WriteLine(result[i]);
            }

        }

        public void Execute2()
        {
            Console.WriteLine("Tapez un mot :");
            string input = Console.ReadLine();
            char[] result = new char[input.Length];
            int index = 0;
            foreach (char c in input)
            {
                result[index] = c;
                Console.WriteLine(result[index]);
                index++;
                if (index < input.Length)
                {
                    Console.WriteLine(".");
                }
            }

            Console.WriteLine("-----");

            result = result.Reverse().ToArray();
        }
    }
}
