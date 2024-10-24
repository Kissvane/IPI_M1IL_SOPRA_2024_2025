using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1IL_Sopra_Exercices
{
    public class Exo18
    {
        public void Execute(int[] array1, int[] array2, int index)
        {
            int[] result = new int[array1.Length+array2.Length];
            int resutIndex = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (i == index)
                {
                    foreach(int j in array2)
                    {
                        result[resutIndex] = j;
                        Console.WriteLine(result[resutIndex]);
                        resutIndex++;
                    }
                }
                result[resutIndex] = array1[i];
                Console.WriteLine(result[resutIndex]);
                resutIndex++;
            }
        }
    }
}
