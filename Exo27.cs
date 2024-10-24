using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1IL_Sopra_Exercices
{
    public class Exo27
    {
        public void Execute()
        {
            Dictionary<string, int> dico = new Dictionary<string, int>();
            dico.Add("Cornebarrieu", 5);
            dico.Add("Toulouse", 8000);
            dico.Add("Viol-Lefort",50);
            dico.Add("Montpellier", 6000);
            dico.Add("Paris", 3000);

            Stopwatch watch = Stopwatch.StartNew();
            dico.ContainsKey("Paris");
            watch.Stop();
            Console.WriteLine($"FIND within 5 elements : {watch.ElapsedTicks}");

            for (int i = 0; i < 10000; i++)
            {
                dico.Add(i.ToString(), i);
            }

            watch.Restart();
            dico.ContainsKey("Toulouse");
            watch.Stop();
            Console.WriteLine($"FIND within 10K elements : {watch.ElapsedTicks}");

            Random random = new Random();

            List<string> keys = dico.Keys.ToList();
            for (int i = 0; i < 5; i++)
            {
                int index = random.Next(keys.Count);
                string key = keys[index];
                Console.WriteLine($"{key} {dico[key]}");
            }

            Console.WriteLine("------------");

            int number = 0;
            foreach (var kvp in dico)
            {
                Console.WriteLine($"{kvp.Key} {kvp.Value}");
                number++;
                if (number >= 5)
                {
                    break;
                }
            }
            
        }
    }
}
