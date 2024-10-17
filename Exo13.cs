using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1IL_Sopra_Exercices
{
    public class Exo13
    {
        public void Execute()
        {
            int result = 0;
            while (true)
            {
                Console.WriteLine("Tapez un nombre");
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    result += input;
                }
                catch(Exception e) 
                {
                    break;
                }
            }

            Console.WriteLine(result);
        }
    }
}
