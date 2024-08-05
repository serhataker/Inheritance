using System;
namespace Inheritance
{

    class Inheritance
    {

        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();//instance for the teacher
            teacher.Name = "Mehmet";
            teacher.Surname = "Eremir";
            teacher.Salary = 52100;
            teacher.TeacherProp();// call the teacher method

            Student student = new Student();//instance for the student
            student.Name = "Hakan";
            student.Surname = "Yurt";
            student.StudentNumber = 1;
            student.StudentProp();// call the student method

        }
    }
}