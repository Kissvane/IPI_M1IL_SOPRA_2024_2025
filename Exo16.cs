using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1IL_Sopra_Exercices
{
    public class Exo16
    {
        public void Execute(int[] array)
        {
            int[] modified = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    modified[i] = i;
                }
                else
                {
                    modified[i] = array[i];
                }
            }

            Console.WriteLine("ORIGINAL");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("MODIFIED");
            foreach (int i in modified)
            {
                Console.WriteLine(i);
            }
        }
    }
}
