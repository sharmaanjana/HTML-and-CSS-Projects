using System;

namespace EFCodeFirstStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SchoolContext())
            {
                Student student = new Student()
                {
                    StudentName = "Anjana"
                };

                db.Students.Add(student);
                db.SaveChanges();

                Console.WriteLine("Student added successfully!");
            }

            Console.ReadLine();
        }
    }
}