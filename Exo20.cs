using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1IL_Sopra_Exercices
{
    public class Exo20
    {
        public void Execute()
        {
            Console.WriteLine("Tapez quelquechose :");
            string input = Console.ReadLine();
            //string modified = input.Replace("#", $"{(char)3}");
            string modified = input.Replace('#', (char)3);
            Console.WriteLine($"Modified string : {modified}");
            
        }
    }
}
