using Microsoft.AspNetCore.Mvc;

namespace ITIMVC.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
