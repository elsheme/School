using Microsoft.AspNetCore.Mvc;
using SchoolProject2.Models;

namespace SchoolProject2.Controllers
{
    public class StudentController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Student student)
        {

            return View(student);
        }


        [HttpDelete]
        public IActionResult Delete(int id)
        {

            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Register(int StudentId , int CourseId) {
        
        return View();
        }



    }


}
