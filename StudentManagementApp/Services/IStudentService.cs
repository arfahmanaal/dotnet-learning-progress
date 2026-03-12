using StudentManagementApp.Models;
namespace StudentManagementApp.Services
{
    public interface IStudentService
    {
        List<Student> GetAll();
        Student GetById(int id);
        void Add(Student student);
        void Update(int id, Student updated);
        void Delete(int id);
    }
}