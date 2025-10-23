using ITIMVC.Context;
using ITIMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITIMVC.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly CompanyContext _context;

        public DepartmentController(CompanyContext context)
        {
            _context = context;
        }

        // GetAll
        public IActionResult GetAll()
        {
            var data = _context.Departments.ToList();
            return View(data);
        }

        // GetById
        public IActionResult GetById(int id)
        {
            var dept = _context.Departments.Find(id);
            if (dept == null)
                return NotFound();

            return View(dept);
        }

        // GetByName
        public IActionResult GetByName(string name)
        {
            var depts = _context.Departments
                .Where(d => d.Name.Contains(name))
                .ToList();

            return View("GetAll", depts);
        }

        // Add (GET)
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        // Add (POST)
        [HttpPost]
        public IActionResult Add(Department department)
        {
            if (ModelState.IsValid)
            {
                _context.Departments.Add(department);
                _context.SaveChanges();
                return RedirectToAction("GetAll");
            }

            return View(department);
        }
    }
}
