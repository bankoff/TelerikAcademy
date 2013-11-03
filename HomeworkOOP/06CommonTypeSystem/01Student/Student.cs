//01. Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, 
//    mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities 
//    and faculties. Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and 
//    operators == and !=.

using System;

class Student : ICloneable, IComparable<Student>
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public int SSN { get; set; }
    public string PermanentAddress { get; set; }
    public string MobilePhone { get; set; }
    public string EMail { get; set; }
    public int Course { get; set; }
    public Specialties Specialty { get; set; }
    public Universities University { get; set; }
    public Faculties Faculty { get; set; }

    public Student(string firstName, string middleName, string lastName, int sSN, string permanentAddress,
        string mobilePhone, string eMail, int course, Specialties specialty, Universities university, Faculties faculty)
    {
        this.FirstName = firstName;
        this.MiddleName = middleName;
        this.LastName = lastName;
        this.SSN = sSN;
        this.PermanentAddress = permanentAddress;
        this.MobilePhone = mobilePhone;
        this.EMail = eMail;
        this.Course = course;
        this.Specialty = specialty;
        this.University = university;
        this.Faculty = faculty;
    }

    public override bool Equals(object param)
    {
        // If the cast is invalid, the result will be null
        Student student = param as Student;

        // Check if we have valid not null Student object
        if (student == null)
        {
            return false;
        }

        // Compare the reference type member fields
        if (!Object.Equals(this.FirstName, student.FirstName))
        {
            return false;
        }
        if (!Object.Equals(this.MiddleName, student.MiddleName))
        {
            return false;
        }
        if (!Object.Equals(this.LastName, student.LastName))
        {
            return false;
        }

        // Compare the value type member fields
        if (this.SSN != student.SSN)
        {
            return false;
        }
        return true;
    }

    public static bool operator ==(Student student1, Student student2)
    {
        return Student.Equals(student1, student2);
    }

    public static bool operator !=(Student student1, Student student2)
    {
        return !(Student.Equals(student1, student2));
    }

    public override int GetHashCode()
    {
        return FirstName.GetHashCode() ^ MiddleName.GetHashCode() ^ LastName.GetHashCode() ^ SSN.GetHashCode();
    }

    public override string ToString()
    {
        return String.Format("Student(Name: {0} {1} {2}, SSN: {3})", this.FirstName, this.MiddleName, this.LastName, this.SSN);
    }

//02. Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into 
//    a new object of type Student.
    public Student Clone()
    {
        Student original = this;
        Student result = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.PermanentAddress,
            this.MobilePhone, this.EMail, this.Course, this.Specialty, this.University, this.Faculty);

        return result;
    }
    
    object ICloneable.Clone()
    {
        return this.Clone();
    }

//03. Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) 
//    and by social security number (as second criteria, in increasing order).
    public int CompareTo(Student otherStudent)
    {
        if (this.FirstName != otherStudent.FirstName)
        {
            return (String.Compare(this.FirstName, otherStudent.FirstName));
        }
        if (this.MiddleName != otherStudent.MiddleName)
        {
            return (String.Compare(this.MiddleName, otherStudent.MiddleName));
        }
        if (this.LastName != otherStudent.LastName)
        {
            return (String.Compare(this.LastName, otherStudent.LastName));
        }
        if (this.SSN != otherStudent.SSN)
        {
            return (this.SSN - otherStudent.SSN);
        }

        return 0;
    }
}