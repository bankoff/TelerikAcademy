using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01School
{
    class Teacher : Human
    {
        public List<Discipline> Disciplines { get; set; }

        public Teacher(string name)
            : base(name)
        {
            this.Disciplines = new List<Discipline>();
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.Disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            this.Disciplines.Remove(discipline);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Teacher: " + this.Name);
            result.AppendLine();

            foreach (var item in Disciplines)
            {
                result.Append(item + "\n");
            }

            return result.ToString();
        }        
    }
}
