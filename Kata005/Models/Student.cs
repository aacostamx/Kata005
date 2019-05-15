
namespace Kata005.Models
{
    public class Student
    {
        public readonly int Id;
        public readonly string Name;
        public readonly int TeacherId;

        public Student()
        {
            Id = default;
            Name = default;
            TeacherId = default;
        }

        public Student(int id, string name, int teacherId)
        {
            Id = id;
            Name = name;
            TeacherId = teacherId;
        }
    }
}
