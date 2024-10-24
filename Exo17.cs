using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1IL_Sopra_Exercices
{
    public class Exo17
    {
        public void Execute(int[] array1, int[] array2)
        {
            int[] result = new int[array1.Length+array2.Length];
            int index = 0;
            for (int i = 0; i < Math.Max(array1.Length, array2.Length); i++)
            {
                if (array1.Length > i)
                {
                    result[index] = array1[i];
                    Console.WriteLine(result[index]);
                    index++;
                }
                if (array2.Length > i) 
                {
                    result[index] = array2[i];
                    Console.WriteLine(result[index]);
                    index++;
                }
            }

            
        }
    }
}
