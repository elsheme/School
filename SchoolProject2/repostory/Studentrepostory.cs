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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Student GetStudentById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudents()
        {

            return (from studentObj in _localContext.Students
                    select studentObj).ToList();
        }

        public void register(int StudentId, int CourseId)
        {
            throw new NotImplementedException();
        }
    }
}
