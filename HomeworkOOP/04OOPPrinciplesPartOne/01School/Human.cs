using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01School
{
    abstract class Human
    {
        public string Name { get; set; }
        public string Comment { get; set; }

        protected Human(string name)
        {
            this.Name = name;
        }
        protected Human(string name, string comment)
            : this(name)
        {
            this.Comment = comment;
        }
    }
}
