using StudentAPI.Models;

namespace StudentAPI.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAllAsync(CancellationToken ct = default);
        Task<List<Student>> GetByGradeAsync(string grade);
        Task<Student?> GetByIdAsync(int id);
        Task<Student> AddAsync(Student student);
        Task UpdateAsync(Student student);
        Task<bool> DeleteAsync(int id);
    }
}