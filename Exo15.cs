using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1IL_Sopra_Exercices
{
    public class Exo15
    {
        public void Execute()
        {
            int[] array = new int[13-5+1];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 5;
            }

            array[2] = 111;

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
