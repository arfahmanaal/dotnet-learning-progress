using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using StudentManagementApp.Models;
using StudentManagementApp.Services;

namespace StudentManagementApp.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly ILogger<StudentsController> _logger;
        private readonly IConfiguration _config;

        public StudentsController(IStudentService studentService, ILogger<StudentsController> logger, IConfiguration config)
        {
            _studentService = studentService;
            _logger = logger;
            _config = config;
        }

        public IActionResult Index()
        {
            var appName = _config.GetValue<string>("AppSettings:AppName");
            _logger.LogInformation("Index action called. App: {AppName}", appName);
            var students = _studentService.GetAll();
            return View(students);
        }

        public IActionResult Details(int id)
        {
            _logger.LogInformation("Details requested for student Id: {StudentId}", id);
            var student = _studentService.GetById(id);
            if (student == null)
            {
                _logger.LogWarning("Student with Id {StudentId} not found", id);
                return NotFound();
            }
            return View(student);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _studentService.Add(student);
                _logger.LogInformation("New student created: {StudentName}", student.Name);
                TempData["Message"] = "Student added!";
                return RedirectToAction("Index");
            }
            _logger.LogWarning("Create failed — invalid model state for {StudentName}", student.Name);
            return View(student);
        }

        public IActionResult Edit(int id)
        {
            _logger.LogInformation("Edit requested for student Id: {StudentId}", id);
            var student = _studentService.GetById(id);
            if (student == null)
            {
                _logger.LogWarning("Student with Id {StudentId} not found for edit", id);
                return NotFound();
            }
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(int id, Student student)
        {
            if (ModelState.IsValid)
            {
                _studentService.Update(id, student);
                _logger.LogInformation("Student Id {StudentId} updated", id);
                TempData["Message"] = "Student updated!";
                return RedirectToAction("Index");
            }
            _logger.LogWarning("Edit failed — invalid model state for Id {StudentId}", id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _studentService.Delete(id);
            _logger.LogWarning("Student Id {StudentId} deleted", id);
            TempData["Message"] = "Student deleted!";
            return RedirectToAction("Index");
        }
    }
}