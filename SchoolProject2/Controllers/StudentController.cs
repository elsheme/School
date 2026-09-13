using Microsoft.AspNetCore.Mvc;
using SchoolProject2.Models;
using SchoolProject2.repostory;

namespace SchoolProject2.Controllers
{
    public class StudentController : Controller
    {

        private readonly IStudentrepostory _studentrepostory;

        public StudentController(IStudentrepostory studentrepostory)
        {
            _studentrepostory = studentrepostory;
        }

        [HttpGet]
        public IActionResult Index()
        {

            List<Student> students = _studentrepostory.GetStudents();
            return View(students);
        }


        [HttpGet]
        public ViewResult Create()
        {


            return View();
        }


        [HttpPost]
        public IActionResult Create(Student student)
        {
            _studentrepostory.Creation(student);
            return View(student);
        }


        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _studentrepostory.Delete(id);
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Register(int StudentId , int CourseId) {
         
            _studentrepostory.register(StudentId, CourseId);
            return View();
        }



    }


}
