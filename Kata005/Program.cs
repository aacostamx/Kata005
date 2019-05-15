using Kata005.Repositories;
using System;

namespace Kata005
{
    class Program
    {
        static void Main(string[] args)
        {
            Principals prinicals = new Principals();
            Teachers teachers = new Teachers();
            Students students = new Students();

            var teacher = teachers.GetById(1);
            Console.WriteLine($"{teacher.Name}");
            var studentsForTeacher = students.GetByTeacherId(teacher.Id);
            foreach(var student in studentsForTeacher)
            {
                Console.WriteLine($"  {student.Name}");
            }
        }
    }
}
