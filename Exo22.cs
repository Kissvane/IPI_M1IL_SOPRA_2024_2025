using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1IL_Sopra_Exercices
{
    public class Exo22
    {
        public void Execute()
        {
            double value1 = EnterANumber();
            double value2 = EnterANumber();
            double value3 = EnterANumber();

            List<double> list = new List<double>();
            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Sort();
            foreach (double d in list)
            {
                Console.WriteLine(d);
            }
        }

        private double EnterANumber()
        {
            double result = 0;
            while (true)
            {
                Console.WriteLine($"Tapez un nombre réel :");
                string input = Console.ReadLine();
                input = input.Replace(',', '.');
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
