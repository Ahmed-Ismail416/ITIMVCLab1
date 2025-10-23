using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        

            DBContext DB = new DBContext();
            public ViewResult GetAll()
            {
                var students = DB.Students.ToList();
                return View("Student", students);

            }
        public ViewResult getById(int id)
        {
            var students = DB.Students.Find(id);
            return View("StudentId", students);

        }

    }
}
