using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1IL_Sopra_Exercices
{
    public class Exo5
    {
        public void Execute()
        {
            Console.WriteLine("Tapez le premier nombre :");
            string input = Console.ReadLine();
            int value1;
            if (!int.TryParse(input, out value1))
            {
                Console.WriteLine("ne tapez que des chiffres SVP !!!");
                return;
            }
            
            Console.WriteLine("Tapez le second nombre :");
            input = Console.ReadLine();
            int value2;
            if (!int.TryParse(input, out value2))
            {
                Console.WriteLine("ne tapez que des chiffres SVP !!!");
                return;
            }

            Addition(value1, value2);
            Division(value1, value2);
        }

        private void Addition(int value1, int value2)
        {
            Console.WriteLine($"{value1} + {value2} = {value1 + value2}");
        }

        private void Division(int value1, int value2)
        {
            Console.WriteLine($"{value1} / {value2} = {value1 / value2} RESTE {value1 % value2}");
        }
    }
}
