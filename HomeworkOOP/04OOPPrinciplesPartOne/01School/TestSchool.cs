using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01School
{
    class TestSchool
    {
        static void Main()
        {
            //Defining Student
            Student student = new Student("Ivan Ivanov", 1234322);
            //Console.WriteLine(student.ToString());

            //Defining Teacher
            Teacher teacher = new Teacher("Petar Petrov");

            //Defining Discipline
            Discipline discipline = new Discipline(DisciplineName.chemistry, 8, 34);
            teacher.AddDiscipline(discipline);
            //Console.WriteLine(teacher.ToString());

            //Defining Class
            ClassOfStudents newClass = new ClassOfStudents("12A");
            newClass.AddStudent(student);
            newClass.AddTeacher(teacher);
            //Console.WriteLine(newClass.ToString());

            //Defining School
            School school = new School();
            school.AddClass(newClass);
            Console.WriteLine(school.ToString());
        }
    }
}