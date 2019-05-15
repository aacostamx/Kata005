using Kata005.Interfaces;
using Kata005.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Kata005.Repositories
{
    public class Principals : Repository<Principal>, IPrincipal
    {
        public Principals()
        {
            Source = new List<Principal>() { new Principal(Guid.NewGuid(), "Dr. Wilson") };
        }

        public override Principal GetByExpression(Expression<Func<Principal, bool>> match)
        {
            return base.GetByExpression(match) ?? new Principal();
        }
    }
}
