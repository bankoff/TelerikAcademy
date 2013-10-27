//3.Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. 
//  Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). 
//  Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only 
//  female and tomcats can be only male. Each animal produces a specific sound. Create arrays of different 
//  kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03Animal
{
    abstract class Animal : ISound
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public bool IsMale { get; set; }
        public string SpecificSound { get; set; }

        protected Animal(int age, string name, bool isMale)
        {
            this.Age = age;
            this.Name = name;
            this.IsMale = isMale;
        }

        public static decimal CalculateAverage(Animal[] animalArr)
        {
            decimal sum = 0;
            decimal count = 0;
            foreach (var animal in animalArr)
            {
                sum += animal.Age;
                count++;
            }
            return sum / count;
        }

        public virtual void MakeSound()
        {
        }
    }
}
