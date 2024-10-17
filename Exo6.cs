using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1IL_Sopra_Exercices
{
    enum TrafficLightColor { GREEN, ORANGE, RED }

    public class Exo6
    {
        public void Execute()
        {
            Console.WriteLine("Tapez la couleur actuelle du feu :");
            string input = Console.ReadLine();
            TrafficLightColor currentColor = GetEnumFromString(input);
            int numberOfChoiceInEnum = Enum.GetValues(typeof(TrafficLightColor)).Length;
            TrafficLightColor nextColor = (TrafficLightColor)((((int)currentColor) + 1) % numberOfChoiceInEnum);
            Console.WriteLine($"Next color is {nextColor}");
        }
        
        private TrafficLightColor GetEnumFromString(string input)
        {
            return (TrafficLightColor) Enum.Parse(typeof(TrafficLightColor), input);
        }

        public void Execute2()
        {
            Console.WriteLine("Tapez la couleur actuelle du feu :");

            
            int numberOfChoiceInEnum = Enum.GetValues(typeof(TrafficLightColor)).Length;
            for (int i = 0; i < numberOfChoiceInEnum; i++)
            {
                Console.WriteLine($"tapez {i} pour {Enum.GetValues(typeof(TrafficLightColor)).GetValue(i)}");
            }
            int input = int.Parse(Console.ReadLine());
            TrafficLightColor currentColor = (TrafficLightColor)input;
            TrafficLightColor nextColor = (TrafficLightColor)((((int)currentColor) + 1) % numberOfChoiceInEnum);
            Console.WriteLine($"Next color is {nextColor}");
        }
    }
}
