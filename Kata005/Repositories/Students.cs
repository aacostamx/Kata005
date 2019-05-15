using Kata005.Interfaces;
using Kata005.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata005.Repositories
{
    public class Students : IRepository<Student>
    {
        private List<Student> _students = new List<Student>()
        {
            new Student(1, "John Doe", 1),
            new Student(2, "Jane Doe", 1),
            new Student(3, "June Doe", 2),
            new Student(4, "Juan Doe", 2),
            new Student(5, "Judy Doe", 2)
        };
        public Student GetById(int id)
        {
            return _students.First(s => s.Id == id);
        }

        public Student GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IList<Student> GetByTeacherId(int teacherId)
        {
            return _students.Where(s => s.TeacherId == teacherId).ToList();
        }
    }
}
