using System;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { Id = 01, FName = "Joe", Lname = "Doe" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }

            //Student student = new Student();

            //student.Id = 1;
            //student.FName = "John";
            //student.Lname = "Doe";
        }
    }
}
