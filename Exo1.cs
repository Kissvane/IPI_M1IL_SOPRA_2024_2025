using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1IL_Sopra_Exercices
{
    public class Exo1
    {
        public void Execute()
        {
            Console.WriteLine("Tapez votre nom :");
            string name = Console.ReadLine();
            Console.WriteLine("Tapez votre prénom :");
            string firstName = Console.ReadLine();

            Console.WriteLine($"Bonjour {firstName} {name}");
        }

        public void Execute2()
        {
            Console.WriteLine("Tapez votre nom :");
            string name = Console.ReadLine();
            Console.WriteLine("Tapez votre prénom :");
            string firstName = Console.ReadLine();

            Console.WriteLine("Bonjour {0} {1}", firstName, name);
        }
    }
}
