using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1IL_Sopra_Exercices
{
    public enum Classes { Maths, French, Biology, Geograpgy, History}

    public class Student
    {
        public string Name { get; private set; }
        public string FirstName { get; private set; }
        public DateTime BirthDay { get; private set; }

        public Dictionary<Classes, float> Grades { get; private set; }

        public Student(string name, string firstName, DateTime birthDay, Dictionary<Classes, float> grades)
        {
            Name = name;
            FirstName = firstName;
            BirthDay = birthDay;
            Grades = grades;
        }

        public float FinalGrade()
        {
            float sum = 0;
            int number = 0;
            foreach (var kvp in Grades)
            {
                sum += kvp.Value;
                number++;
            }

            return sum / (float)number;
        }

    }
}
