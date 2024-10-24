using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1IL_Sopra_Exercices
{
    public class Exo25
    {
        public void Execute()
        {
            HashSet<int> hashset = new HashSet<int>();
            List<int> list = new List<int>();

            Stopwatch watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i <= 1000000; i++)
            {
                hashset.Add(i);
            }
            watch.Stop();
            Console.WriteLine($"Hashset time ADD : {watch.ElapsedTicks}");

            watch.Reset();
            watch.Start();
            for (int i = 0; i <= 1000000; i++)
            {
                list.Add(i);
            }
            watch.Stop();
            Console.WriteLine($"List time ADD : {watch.ElapsedTicks}");

            watch.Reset();
            watch.Start();

            hashset.Contains(800000);

            watch.Stop();
            Console.WriteLine($"Hashset time CONTAINS : {watch.ElapsedTicks}");

            watch.Reset();
            watch.Start();

            list.Contains(800000);

            watch.Stop();
            Console.WriteLine($"list time CONTAINS : {watch.ElapsedTicks}");

            watch.Reset();
            watch.Start();

            hashset.Remove(800000);

            watch.Stop();
            Console.WriteLine($"Hashset time REMOVE : {watch.ElapsedTicks}");

            watch.Reset();
            watch.Start();

            list.Remove(800000);

            watch.Stop();
            Console.WriteLine($"list time REMOVE : {watch.ElapsedTicks}");
        }
    }
}
