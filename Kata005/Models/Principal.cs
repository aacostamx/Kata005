using System;

namespace Kata005.Models
{
    public class Principal
    {
        public readonly Guid Id;
        public readonly string Name;

        public Principal()
        {
            Id = default;
            Name = default;
        }

        public Principal(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
