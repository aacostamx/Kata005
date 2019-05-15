using Kata005.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Kata005.Repositories
{
    public abstract class Repository<T> : IRepository<T>
    {
        public List<T> Source { get; set; }
        public Repository() => Source = default;

        public virtual T GetByExpression(Expression<Func<T, bool>> match)
        {
            return Source.AsQueryable().FirstOrDefault(match);
        }
    }
}
