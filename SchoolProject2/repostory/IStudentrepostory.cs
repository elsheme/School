using SchoolProject2.Models;

namespace SchoolProject2.repostory
{
    public interface IStudentrepostory
    {

        public List<Student> GetStudents();
        public Student GetStudentById(int id);
        public void Creation(Student student);
          
        public void Delete(int id);

        public void register(int StudentId, int CourseId);
    }
}
