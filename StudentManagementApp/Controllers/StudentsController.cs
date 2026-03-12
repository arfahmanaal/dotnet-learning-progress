using Microsoft.AspNetCore.Mvc;
using StudentManagementApp.Models;
using StudentManagementApp.Services;

namespace StudentManagementApp.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public IActionResult Index()
            => View(_studentService.GetAll());

        public IActionResult Details(int id)
        {
            var student = _studentService.GetById(id);
            if (student == null) return NotFound();
            return View(student);
        }

        [HttpGet] public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Student student)
        {
            _studentService.Add(student);
            TempData["Message"] = "Student added!";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var student = _studentService.GetById(id);
            if (student == null) return NotFound();
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(int id, Student updated)
        {
            _studentService.Update(id, updated);
            TempData["Message"] = "Student updated!";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _studentService.Delete(id);
            TempData["Message"] = "Student deleted!";
            return RedirectToAction("Index");
        }
    }
}