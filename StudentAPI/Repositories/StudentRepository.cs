using Microsoft.EntityFrameworkCore;
using StudentAPI.Data;
using StudentAPI.Exceptions;
using StudentAPI.Models;

namespace StudentAPI.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _context;

        public StudentRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Student>> GetAllAsync(CancellationToken ct = default)
            => await _context.Students.ToListAsync(ct);

        public async Task<Student?> GetByIdAsync(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null)
                throw new NotFoundException("Student", id);
            return student;
        }

        public async Task<List<Student>> GetByGradeAsync(string grade)
            => await _context.Students
               .Where(s => s.Grade == grade)
               .OrderBy(s => s.Name)
               .ToListAsync();
        public async Task<Student> AddAsync(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return student;
        }

        public async Task UpdateAsync(Student student)
        {
            var existing = await _context.Students.FindAsync(student.Id);
            if (existing == null)
                throw new NotFoundException("Student", student.Id);
            existing.Name  = student.Name;
            existing.Age   = student.Age;
            existing.Grade = student.Grade;
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null)
                throw new NotFoundException("Student", id);
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}