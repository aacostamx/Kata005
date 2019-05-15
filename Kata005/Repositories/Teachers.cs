using Kata005.Interfaces;
using Kata005.Models;
using System.Collections.Generic;

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

    }
}
