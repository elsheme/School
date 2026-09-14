using Microsoft.AspNetCore.Mvc;
using SchoolProject2.Models;
using SchoolProject2.repostory;

namespace SchoolProject2.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourserepostory _courseRepostory;

        [HttpGet]
        public IActionResult Index()
        {
            List<Course> courses = _courseRepostory.GetCourses();
            return View(courses);

        }
        [HttpPost]
        public IActionResult Creation(Course course)
        {
            if (ModelState.IsValid)
            {
                _courseRepostory.Creation(course);
                return RedirectToAction("Index");
            }
            return View(course);
        }

        [HttpDelete]
        public IActionResult Delete(int id) {

            _courseRepostory.DeleteCourse(id);
            return RedirectToAction("Index");

        }



    }
}
