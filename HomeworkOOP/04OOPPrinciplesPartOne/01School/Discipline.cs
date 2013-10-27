using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01School
{
    class Discipline
    {
        public DisciplineName Name { get; set; }
        public byte NumberOfLectures { get; set; }
        public byte NumberOfExercises { get; set; }
        public string Comments { get; set; }

        public Discipline(DisciplineName name, byte numberOfLectures, byte numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }
        public Discipline(DisciplineName name, byte numberOfLectures, byte numberOfExercises, string comments)
            : this(name, numberOfLectures, numberOfExercises)
        {
            this.Comments = comments;
        }

        public override string ToString()
        {
            string result = "Discipline: " + this.Name + " Number of lectures: " + this.NumberOfLectures + " Number of Exercises " + this.NumberOfExercises;            
            return result;
        }
    }
}
