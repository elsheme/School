using Microsoft.AspNetCore.Mvc;
using SchoolProject2.Models;
using SchoolProject2.repostory;

namespace SchoolProject2.Controllers
{
    public class TeacherController : Controller
    {

        private readonly ITeacherrepostory _teacherrepostory;
        public TeacherController(ITeacherrepostory teacherrepostory)
        {
            _teacherrepostory = teacherrepostory;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<Teacher> teachers = _teacherrepostory.GetTeachers();
            return View(teachers);
        }   


        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Teacher teacher)
        {
            _teacherrepostory.Creation(teacher);
            return View(teacher);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _teacherrepostory.Delete(id);
            return View();
        }
    }
}
