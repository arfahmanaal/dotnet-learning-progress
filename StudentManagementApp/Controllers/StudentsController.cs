using Microsoft.AspNetCore.Mvc;
using StudentManagementApp.Models;

namespace StudentManagementApp.Controllers
{
    public class StudentsController : Controller
    {
        private static List<Student> _students = new List<Student>
        {
            new Student { Id = 1, Name = "John", Age = 20, Grade = "A" },
            new Student { Id = 2, Name = "Steve", Age = 21, Grade = "B" },
            new Student { Id = 3, Name = "Bill", Age = 19, Grade = "A" },
        };
        private static int _nextId = 4;

        public IActionResult Index()
        {
            return View(_students);
        }

        public IActionResult Details(int id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            if (student == null) return NotFound();
            return View(student);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            student.Id = _nextId++;
            _students.Add(student);
            TempData["Message"] = "Student added!";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            if (student == null) return NotFound();
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(int id, Student updated)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            if (student == null) return NotFound();
            student.Name  = updated.Name;
            student.Age   = updated.Age;
            student.Grade = updated.Grade;
            TempData["Message"] = "Student updated!";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            if (student == null) return NotFound();
            _students.Remove(student);
            TempData["Message"] = "Student deleted!";
            return RedirectToAction("Index");
        }
    }
}