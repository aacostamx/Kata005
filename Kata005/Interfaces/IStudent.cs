using Kata005.Models;
using System.Collections.Generic;

namespace Kata005.Interfaces
{
    public interface IStudent : IRepository<Student>
    {
        List<Student> GetByTeacherId(int teacherId);
    }
}
