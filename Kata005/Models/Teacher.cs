﻿
namespace Kata005.Models
{
    public class Teacher
    {
        public readonly int Id;
        public readonly string Name;
        public Teacher(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
