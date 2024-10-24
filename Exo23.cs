using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1IL_Sopra_Exercices
{
    public class Exo23
    {
        public void Execute()
        {
            double value1 = EnterANumber();
            double value2 = EnterANumber();
            double value3 = EnterANumber();

            Random random = new Random();
            double value4 = 1 + random.NextDouble()*99.0;
            Console.WriteLine($"RANDOM {value4}");
            double value5 = 1 + random.NextDouble()*99.0;
            Console.WriteLine($"RANDOM {value5}");
            double value6 = 1 + random.NextDouble()*99.0;
            Console.WriteLine($"RANDOM {value5}");

            List<double> list = new List<double>();
            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5);
            list.Add(value6);
            list.Sort();
            list.Reverse();
            foreach (double i in list)
            {
                Console.WriteLine(i);
            }
        }

        private double EnterANumber()
        {
            double result = 0;
            while (true)
            {
                Console.WriteLine($"Tapez un nombre réel :");
                string input = Console.ReadLine();
                input = input.Replace(',','.');
                try
                {
                    //invariant culture to accept , and . as separators
                    result = double.Parse(input, CultureInfo.InvariantCulture);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ne tapez que des chiffres et éventuellement le séparateur SVP.");
                }
            }

            return result;
        }
    }
}
