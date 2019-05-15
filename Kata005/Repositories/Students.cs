using Kata005.Interfaces;
using Kata005.Models;
using System.Collections.Generic;
using System.Linq;

namespace Kata005.Repositories
{
    public class Students : Repository<Student>, IStudent
    {
        public Students(List<Student> source)
        {
            Source = new List<Student>()
            {
                new Student(1, "John Doe", 1),
                new Student(2, "Jane Doe", 1),
                new Student(3, "June Doe", 2),
                new Student(4, "Juan Doe", 2),
                new Student(5, "Judy Doe", 2)
            };
        }

        public List<Student> GetByTeacherId(int teacherId)
        {
            return Source.Where(c => c.TeacherId == teacherId).ToList();
        }
    }
}
