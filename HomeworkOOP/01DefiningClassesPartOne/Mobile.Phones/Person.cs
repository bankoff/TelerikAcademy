using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mobile.Phones
{
    public class Person
    {
        private string name;

        public Person(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
    }
}
