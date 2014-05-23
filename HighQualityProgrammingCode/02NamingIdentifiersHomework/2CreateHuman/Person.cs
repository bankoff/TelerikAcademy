namespace _2CreateHuman
{
    public class Person
    {
        public Gender Sex { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public static Person CreatePerson(int age)
        {
            Person newPerson = new Person();

            newPerson.Age = age;
            if (age % 2 == 0)
            {
                newPerson.Name = "Sturdy";
                newPerson.Sex = Gender.Male;
            }
            else
            {
                newPerson.Name = "Eyeful";
                newPerson.Sex = Gender.Female;
            }

            return newPerson;
        }
    }
}
