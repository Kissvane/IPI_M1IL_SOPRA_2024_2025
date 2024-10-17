using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1IL_Sopra_Exercices
{
    public class Exo7
    {
        public void Execute()
        {
            Console.WriteLine("tapez une temperature :");
            int temperature = int.Parse(Console.ReadLine());
            if (temperature <= 0)
            {
                Console.WriteLine("Etat solide");
            }
            else if(temperature < 100)
            {
                Console.WriteLine("Etat liquide");
            }
            else
            {
                Console.WriteLine("Etat gazeux");
            }
        }
    }
}
