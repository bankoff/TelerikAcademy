using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03Animal
{
    class Dog : Animal
    {
        public Dog(int age, string name, bool isMale)
            : base(age, name, isMale)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine(this.Name + " said: Djaf-djaf");
        }
    }
}