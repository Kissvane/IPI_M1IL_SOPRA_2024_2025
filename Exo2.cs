using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1IL_Sopra_Exercices
{
    public class Exo2
    {
        public void Execute()
        {
            Console.WriteLine("Tapez votre année de naissance :");
            string input = Console.ReadLine();
            int birthYear = int.Parse(input);
            int age = DateTime.Now.Year - birthYear;
            Console.WriteLine($"Vous avez {age} ans");
        }

        public void Execute2()
        {
            Console.WriteLine("Tapez votre année de naissance :");
            string input = Console.ReadLine();
            int birthYear = int.Parse(input);
            int age = 2024 - birthYear;
            Console.WriteLine($"Vous avez {age} ans");
        }

        public void Execute3()
        {
            Console.WriteLine("Tapez votre année de naissance :");
            int birthYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Tapez votre mois de naissance :");
            int birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Tapez votre jour de naissance :");
            int birthDay = int.Parse(Console.ReadLine());

            DateTime birthDate = new DateTime(birthYear, birthMonth, birthDay);
            int age = DateTime.Now.Year - birthYear;

            //birthmonth hasnt come yet
            if (DateTime.Now.Month < birthMonth)
            {
                age--;
            }
            //birthday hasnt come yet
            else if (DateTime.Now.Month == birthMonth && DateTime.Now.Day < birthDay)
            {
                age--;
            }

            Console.WriteLine($"Vous avez {age} ans");
        }
    }
}
