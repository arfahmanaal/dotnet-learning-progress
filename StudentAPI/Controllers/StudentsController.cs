using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;

namespace StudentAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private static List<Student> _students = new List<Student>
        {
            new Student { Id = 1, Name = "John", Age = 20, Grade = "A" },
            new Student { Id = 2, Name = "Steve", Age = 21, Grade = "B" },
            new Student { Id = 3, Name = "Bill", Age = 19, Grade = "A" },
        };
        private static int _nextId = 4;

        [HttpGet]
        public ActionResult<List<Student>> GetAll()
        {
            return Ok(_students);
        }

        [HttpGet("{id}")]
        public ActionResult<Student> GetById(int id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            if (student == null) return NotFound();
            return Ok(student);
        }

        [HttpPost]
        public ActionResult<Student> Create(Student student)
        {
            student.Id = _nextId++;
            _students.Add(student);
            return CreatedAtAction(nameof(GetById), new { id = student.Id }, student);
        }
    }
}