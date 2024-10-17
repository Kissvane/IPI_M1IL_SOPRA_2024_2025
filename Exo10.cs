using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1IL_Sopra_Exercices
{
    public class Exo10
    {
        public void Execute()
        {
            Console.WriteLine("Tapez un nombre :");
            int input = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 1; i <= input; i++)
            {
                result += i;
            }

            Console.WriteLine(result);
        }
    }
}
