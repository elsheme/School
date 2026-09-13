using SchoolProject2.Dbcontext;
using SchoolProject2.Models;

namespace SchoolProject2.repostory
{
    public class Courserepostory : ICourserepostory
    {       
        private readonly LocalDbContext _context;
        public void Creation(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public void DeleteCourse(int id)
        {
            var course = _context.Courses.Find(id);
            if (course != null)
            {
                _context.Courses.Remove(course);
                _context.SaveChanges();
            }
        }
        

        public Course GetCourseById(int id)
        {
            return _context.Courses.Find(id);
        }

        public List<Course> GetCourses()
        {
            return _context.Courses.ToList();
        }
    }
}
