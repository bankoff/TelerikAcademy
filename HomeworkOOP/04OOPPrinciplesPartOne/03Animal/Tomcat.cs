using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03Animal
{
    class Tomcat : Cat
    {
        public Tomcat(int age, string name, bool isMale)
            : base(age, name, isMale)
        {
            try
            {
                if (isMale == false)
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.IsMale = isMale;
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("TomCats can only be male!");
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine(this.Name + " said: Mrrrr....Myauuuu.....");
        }
    }
}
