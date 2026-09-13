using SchoolProject2.Models;

namespace SchoolProject2.repostory
{
    public interface ICourserepostory
    {
        public List<Course> GetCourses();
        public Course GetCourseById(int id);

        public void Creation(Course course);
        public void DeleteCourse(int id);
    }
}
