using Kata005.Interfaces;
using Kata005.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata005.Repositories
{
    public class Teachers : IRepository<Teacher>
    {
        private List<Teacher> _teachers = new List<Teacher>()
        {
            new Teacher(1, "Mr. Jones"),
            new Teacher(2, "Ms . Smith")
        };
        public Teacher GetById(int id)
        {
            return _teachers.First(t => t.Id == id);
        }

        public IList<Student> GetByTeacherId(int teacherId)
        {
            throw new NotImplementedException();
        }

        Teacher IRepository<Teacher>.GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        IList<Teacher> IRepository<Teacher>.GetByTeacherId(int teacherId)
        {
            throw new NotImplementedException();
        }
    }
}
