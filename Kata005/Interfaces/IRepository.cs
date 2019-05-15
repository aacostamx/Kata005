using System;
using System.Collections.Generic;

namespace Kata005.Interfaces
{
    public interface IRepository<T>
    {
        T GetById(int id);
        T GetById(Guid id);

        IList<T> GetByTeacherId(int teacherId);

    }
}
