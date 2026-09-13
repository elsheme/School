using Microsoft.AspNetCore.Mvc;

namespace SchoolProject2.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
