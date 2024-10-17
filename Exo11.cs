using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1IL_Sopra_Exercices
{
    public class Exo11
    {
        public void Execute()
        {
            string result = "";
            StringBuilder builder = new StringBuilder();
            for (int i = 30; i >= 0; i-=3)
            {
                builder.Append($"{i}-");
            }
            builder.Remove(builder.Length-1,1);
            Console.WriteLine(builder.ToString());
        }
    }
}
