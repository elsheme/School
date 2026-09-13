using SchoolProject2.Dbcontext;
using SchoolProject2.Models;

namespace SchoolProject2.repostory
{
    public class Studentrepostory : IStudentrepostory
    {

        private readonly LocalDbContext _localContext;

        public Studentrepostory(LocalDbContext localContext)
        {
            _localContext = localContext;
        }
        public void Creation(Student student)
        {
            try
            {

                _localContext.Students.Add(student);
                _localContext.SaveChanges();

            }
            catch (Exception ex)
            {

            }
        }

        public void Delete(int id)
        {
            try {
            
              Student obj = GetStudentById(id);
              _localContext.Students.Remove(obj);
                _localContext.SaveChanges();
            }catch (Exception ex) { }
        }

        public Student GetStudentById(int id)
        {
           return _localContext.Students.SingleOrDefault(x => x.Id == id);
        }

        public List<Student> GetStudents()
        {
            try
            {
                return (from studentObj in _localContext.Students
                        select studentObj).ToList();
            }
            catch (Exception e)
            {

                string msg = e.Message;

                return null;

            }


        }

        public void register(int StudentId, int CourseId)
        {
            try {
                StudentCourse studentCourse = new StudentCourse();
                studentCourse.CourseId = CourseId;
                studentCourse.StudentId = StudentId;

                _localContext.StudentCourses.Add(studentCourse);
                _localContext.SaveChanges();
            }
            catch (Exception ex) { }
        }
    }
}
