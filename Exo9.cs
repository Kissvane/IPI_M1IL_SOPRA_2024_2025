using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1IL_Sopra_Exercices
{
    public class Exo9
    {
        public void Execute()
        {
            for (int i = 0; i <= 20; i++) 
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void Execute2()
        {
            for (int i = 0; i <= 20; i+=2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
