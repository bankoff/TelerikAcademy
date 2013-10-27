using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03Animal
{
    class TestAnimal
    {
        static void Main()
        {
            Dog dogOne = new Dog(7, "Sharo", true);
            Dog dogTwo = new Dog(11, "Sara", false);
            Dog dogThree = new Dog(2, "Tara", false);
            Dog[] dogArr = new Dog[] { dogOne, dogTwo, dogThree };
            Console.WriteLine("The average age of dogs is {0:F2} years old.", Animal.CalculateAverage(dogArr));
            foreach (var dog in dogArr)
            {
                dog.MakeSound();
            }

            Frog frogOne = new Frog(1, "Skokla", false);
            Frog frogTwo = new Frog(3, "Handsome", true);
            Frog frogThree = new Frog(2, "Skokancho", true);
            Frog[] frogArr = new Frog[] { frogOne, frogTwo, frogThree };
            Console.WriteLine("The average age of frogs is {0:F2} years old.", Animal.CalculateAverage(frogArr));
            foreach (var frog in frogArr)
            {
                frog.MakeSound();
            }

            Kitten kittenOne = new Kitten(1, "Hihi", false);
            Kitten kittenTwo = new Kitten(2, "Kiki", false);
            Kitten kittenThree = new Kitten(3, "Kenny", false);
            Kitten[] kittenArr = new Kitten[] { kittenOne, kittenTwo, kittenThree };
            Console.WriteLine("The average age of kittens is {0:F2} years old.", Animal.CalculateAverage(kittenArr));
            foreach (var kitten in kittenArr)
            {
                kitten.MakeSound();
            }

            Tomcat tomcatOne = new Tomcat(4, "Pancho", true);
            Tomcat tomcatTwo = new Tomcat(6, "Robby", true);
            Tomcat tomcatThree = new Tomcat(7, "Vasko", true);
            Tomcat[] tomcatArr = new Tomcat[] { tomcatOne, tomcatTwo, tomcatThree };
            Console.WriteLine("The average age of tomcats is {0:F2} years old.", Animal.CalculateAverage(tomcatArr));
            foreach (var tomcat in tomcatArr)
            {
                tomcat.MakeSound();
            }
        }
    }
}
