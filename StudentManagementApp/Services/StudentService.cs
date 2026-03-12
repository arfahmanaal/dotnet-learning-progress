using StudentManagementApp.Models;

namespace StudentManagementApp.Services
{
    public class StudentService : IStudentService
    {
        private static List<Student> _students = new List<Student>
        {
            new Student { Id = 1, Name = "John", Age = 20, Grade = "A" },
            new Student { Id = 2, Name = "Steve", Age = 21, Grade = "B" },
            new Student { Id = 3, Name = "Bill", Age = 19, Grade = "A" },
        };
        private static int _nextId = 4;

        public List<Student> GetAll() => _students;

        public Student GetById(int id)
            => _students.FirstOrDefault(s => s.Id == id);

        public void Add(Student student)
        {
            student.Id = _nextId++;
            _students.Add(student);
        }

        public void Update(int id, Student updated)
        {
            var s = _students.FirstOrDefault(x => x.Id == id);
            if (s == null) return;
            s.Name = updated.Name;
            s.Age = updated.Age;
            s.Grade = updated.Grade;
        }

        public void Delete(int id)
        {
            var s = _students.FirstOrDefault(x => x.Id == id);
            if (s == null) return;
            _students.Remove(s);
        }
    }
}