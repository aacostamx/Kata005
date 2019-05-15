using Kata005.Interfaces;
using Kata005.Models;
using System;
using System.Collections.Generic;

namespace Kata005.Repositories
{
    public class Principals : Repository<Principal>, IPrincipal
    {
        public Principals()
        {
            Source = new List<Principal>() { new Principal(Guid.NewGuid(), "Dr. Wilson") };
        }
    }
}
