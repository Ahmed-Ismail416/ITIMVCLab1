using ITIMVC.Context;
using ITIMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITIMVC.Controllers
{
    public class StudentController : Controller
    {
        CompanyContext context = new CompanyContext();

        // get all
        public IActionResult GetAll()
        {
            var data = context.Students.ToList();
            return View(data);
        }

        // get by id
        public IActionResult GetById(int id)
        {
            var data = context.Students.Find(id);
            return View(data);
        }
    }
}
