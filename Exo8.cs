using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1IL_Sopra_Exercices
{
    public class Exo8
    {
        public void Execute()
        {
            int value1 = EnterAValidValue();
            int value2 = EnterAValidValue();
            
            Addition(value1, value2);
            Division(value1, value2);
        }

        private int EnterAValidValue()
        {
            bool inputIsValid = false;
            int result = 0;

            while (!inputIsValid) 
            {
                Console.WriteLine("Tapez un nombre :");
                try
                {
                    result = int.Parse(Console.ReadLine());
                    inputIsValid = true;
                }
                catch (Exception e)
                {
                    inputIsValid = false;
                    Console.WriteLine("Tapez seulement des chiffres SVP !!!");
                }
            }

            return result;
        }

        private void Addition(int value1, int value2)
        {
            Console.WriteLine($"{value1} + {value2} = {value1 + value2}");
        }

        private void Division(int value1, int value2)
        {
            try
            {
                Console.WriteLine($"{value1} / {value2} = {value1 / value2} RESTE {value1 % value2}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Division by zero is impossible.");
            }
        }
    }
}

