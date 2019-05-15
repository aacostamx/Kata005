using System;
using System.Linq.Expressions;

namespace Kata005.Interfaces
{
    public interface IRepository<T>
    {
        T GetByExpression(Expression<Func<T, bool>> match);
    }
}
