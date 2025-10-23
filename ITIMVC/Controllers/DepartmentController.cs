using ITIMVC.Context;
using ITIMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ITIMVC.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly CompanyContext _context;

        public DepartmentController(CompanyContext context)
        {
            _context = context;
        }

        // GET: Department/GetAll
        public IActionResult GetAll()
        {
            var data = _context.Departments.ToList();
            return View(data);
        }

        // GET: Department/Details/5
        public IActionResult Details(int id)
        {
            var dept = _context.Departments.FirstOrDefault(d => d.DeptId == id);
            if (dept == null) return NotFound();
            return View(dept);
        }

        // GET: Department/Add
        public IActionResult Add()
        {
            return View();
        }

        // POST: Department/Add
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Department dept)
        {
            if (ModelState.IsValid)
            {
                _context.Departments.Add(dept);
                _context.SaveChanges();
                return RedirectToAction(nameof(GetAll));
            }
            return View(dept);
        }

        // GET: Department/Edit/5
        public IActionResult Edit(int id)
        {
            var dept = _context.Departments.Find(id);
            if (dept == null) return NotFound();
            return View(dept);
        }

        // POST: Department/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Department dept)
        {
            if (id != dept.DeptId) return BadRequest();

            if (ModelState.IsValid)
            {
                _context.Departments.Update(dept);
                _context.SaveChanges();
                return RedirectToAction(nameof(GetAll));
            }

            return View(dept);
        }

        // GET: Department/Delete/5
        public IActionResult Delete(int id)
        {
            var dept = _context.Departments.Find(id);
            if (dept == null) return NotFound();
            return View(dept);
        }

        // POST: Department/DeleteConfirmed/5
        [HttpPost, ActionName("DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var dept = _context.Departments.Find(id);
            if (dept != null)
            {
                _context.Departments.Remove(dept);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(GetAll));
        }
    }
}
