using SchoolProject2.Dbcontext;
using SchoolProject2.Models;

namespace SchoolProject2.repostory
{
    public class Teacherrepostory : ITeacherrepostory
    {


        private readonly LocalDbContext _context;

        public Teacherrepostory(LocalDbContext context)
        {
            _context = context;
        }
        public void Creation(Teacher teacher)
        {
            try
            {
                _context.Teachers.Add(teacher);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("An error occurred while creating the teacher.", ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                Teacher obj = GetTeacherById(id);
                if (obj != null)
                {
                    _context.Teachers.Remove(obj);
                    _context.SaveChanges();
                }
                else
                {
                    throw new Exception($"Teacher with ID {id} not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the teacher.", ex);
            }
        }

        public Teacher GetTeacherById(int id)
        {
            try
            {
                return _context.Teachers.FirstOrDefault(t => t.Id == id);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving the teacher.", ex);
            }
        }
        

        public List<Teacher> GetTeachers()
        {
            try
            {
                return _context.Teachers.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving the teachers.", ex);
            }
        }
    }
}
