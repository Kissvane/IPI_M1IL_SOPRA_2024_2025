using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1IL_Sopra_Exercices
{
    public class Exo24
    {
        public void Execute()
        {
            List<string> Names = new List<string>();
            bool userHasEnteredANumber = false;
            while (Names.Count < 6 || !userHasEnteredANumber)
            {
                string enteredName = EnterAName(Names.Count < 6, out userHasEnteredANumber);
                Names.Add(enteredName);
            }

            Names.RemoveAt(4);
            Names.RemoveAt(1);

            Names.Insert(2, "Toto");
            Names.Reverse();

            foreach (string name in Names)
            {
                Console.WriteLine(name);
            }
        }

        private string EnterAName(bool mandatory, out bool isNumber)
        {
            while (true)
            {
                Console.WriteLine($"Entrez un nom :");
                string input = Console.ReadLine();
                if (mandatory) 
                {
                    if (IsANumber(input))
                    {
                        Console.WriteLine("Il n'y a pas encore assez de nom dans la liste. Continuez  entrer des noms svp.");
                    }
                    else
                    {
                        isNumber = false;
                        return input;
                    }
                }
                else
                {
                    isNumber = IsANumber(input);
                    return null;
                }
            }

        }

        private bool IsANumber(string input)
        {
            input = input.Replace(',', '.');
            try
            {
                //invariant culture to accept , and . as separators
                double result = double.Parse(input, CultureInfo.InvariantCulture);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
