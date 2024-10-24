using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1IL_Sopra_Exercices
{
    public enum Levels { PS, MS, GS, CP, CE1, CE2, CM1, CM2 }

    public class Class
    {
        public string Name { get; private set; }
        public Levels Level { get; private set; } = Levels.PS;

        public int MaxStudentNumber { get; private set; } = 30;

        public List<Student> students =  new List<Student>();

        public Class(string name, Levels level, int maxStudentNumber, List<Student> students)
        {
            Name = name;
            Level = level;
            MaxStudentNumber = maxStudentNumber;
            this.students = students;
        }

        public List<Student> Promotion()
        {
            List<Student> result = new List<Student>();
            foreach (Student student in students)
            {
                if (student.FinalGrade() >= 10)
                {
                    result.Add(student);
                }
            }

            return result;
        }
    }
}
