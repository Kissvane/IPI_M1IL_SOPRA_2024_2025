using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace M1IL_Sopra_Exercices
{
    public class Exo3
    {
        public void Execute()
        {
            Console.WriteLine("Tapez le prix d'un produit :");
            float price = float.Parse(Console.ReadLine());
            Console.WriteLine("Tapez le taux de tva :");
            float tvaRate = float.Parse(Console.ReadLine());
            float tva = price * tvaRate / 100;
            float ttcPrice = price + tva;
            Console.WriteLine($"Le prix TTC est de {ttcPrice}");
        }
    }
}
