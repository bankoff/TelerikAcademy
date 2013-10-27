using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03Animal
{
    abstract class Cat : Animal
    {
        public Cat(int age, string name, bool isMale)
            : base(age, name, isMale)
        {
        }
    }
}