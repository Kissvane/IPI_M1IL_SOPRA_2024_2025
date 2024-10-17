using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1IL_Sopra_Exercices
{
    public class Exo14
    {
        public void Execute()
        {
            Console.WriteLine("Taper un nombre :");
            int value = int.Parse(Console.ReadLine());
            int result = 0;
            while (value > 1)
            {
                value /= 2;
                result++;
            }

            Console.WriteLine(result);
        }
    }
}
