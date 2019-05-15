using Kata005.Interfaces;
using Kata005.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata005.Repositories
{
    public class Principals : IRepository<Principal>
    {
        private List<Principal> _prinicpals = new List<Principal>()
        {
            new Principal(Guid.NewGuid(), "Dr. Wilson")
        };
        public Principal GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Principal GetById(Guid id)
        {
            return _prinicpals.First(p => p.Id == id);
        }

        public IList<Principal> GetByTeacherId(int teacherId)
        {
            throw new NotImplementedException();
        }
    }
}
