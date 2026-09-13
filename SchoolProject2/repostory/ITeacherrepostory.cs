using SchoolProject2.Models;

namespace SchoolProject2.repostory
{
    public interface ITeacherrepostory
    {


        public List<Teacher> GetTeachers();
        public Teacher GetTeacherById(int id);
        public void Creation(Teacher teacher);
        public void Delete(int id);
        
    }
}
