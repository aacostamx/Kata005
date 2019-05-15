using Kata005.Interfaces;
using Kata005.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Kata005.Repositories
{
    public class Teachers : Repository<Teacher>, ITeacher
    {
        public Teachers()
        {
            Source = new List<Teacher>()
            {
                new Teacher(1, "Mr. Jones"),
                new Teacher(2, "Ms . Smith")
            };
        }

        public override Teacher GetByExpression(Expression<Func<Teacher, bool>> match)
        {
            return base.GetByExpression(match) ?? new Teacher();
        }
    }
}
