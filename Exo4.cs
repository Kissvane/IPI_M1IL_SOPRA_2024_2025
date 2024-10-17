using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1IL_Sopra_Exercices
{
    public class Exo4
    {
        public void Execute()
        {
            Console.WriteLine("Tapez le premier nombre :");
            int value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tapez le second nombre :");
            int value2 = int.Parse(Console.ReadLine());

            Addition(value1, value2);
            Division(value1, value2);
        }

        private void Addition(int value1, int value2)
        {
            Console.WriteLine($"{value1} + {value2} = {value1+value2}");
        }

        private void Division(int value1, int value2)
        {
            Console.WriteLine($"{value1} / {value2} = {value1 / value2} RESTE {value1 % value2}");
        }
    }
}
