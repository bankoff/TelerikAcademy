namespace Methods
{
    using System;
    using System.Globalization;

    public class Student
    {
        public Student(string firstName, string lastName, string additionalInfo)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AdditionalInfo = additionalInfo;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string AdditionalInfo { get; set; }

        public DateTime BirthDate()
        {
            string birthDateString = this.AdditionalInfo.Substring(this.AdditionalInfo.Length - 10);
            DateTime birthDate = DateTime.ParseExact(birthDateString, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            return birthDate;
        }
    }
}
