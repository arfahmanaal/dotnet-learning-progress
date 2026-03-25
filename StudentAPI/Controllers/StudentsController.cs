using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;
using StudentAPI.Repositories;
using Microsoft.AspNetCore.Authorization;

namespace StudentAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize] 
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepository _repository;

        public StudentsController(IStudentRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAll(CancellationToken ct)
        {
            return Ok(await _repository.GetAllAsync(ct));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetById(int id)
        {
            var student = await _repository.GetByIdAsync(id);
            return Ok(student);
        }

        [HttpGet("grade/{grade}")]
        public async Task<ActionResult<List<Student>>> GetByGrade(string grade)
        {
            return Ok(await _repository.GetByGradeAsync(grade));
        }
        
        [HttpPost]
        public async Task<ActionResult<Student>> Create(Student student)
        {
            var created = await _repository.AddAsync(student);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Student student)
        {
            if (id != student.Id) return BadRequest();
            await _repository.UpdateAsync(student);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteAsync(id);
            return NoContent();
        }
    }
}