using SchoolProject2.Dbcontext;
using SchoolProject2.Models;

namespace SchoolProject2.repostory
{
    public class Roomrepostory : IRoomrepostory
    {

        private readonly LocalDbContext _context;
        public Roomrepostory(LocalDbContext context)
        {
            _context = context;
        }
        public void Creation(Room room)
        {
            try
            {
                _context.Rooms.Add(room);
                _context.SaveChanges();
            
            }
            catch (Exception ex)
            {
                // Handle exceptions
                throw new Exception("An error occurred while creating the room.", ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                Room obj = GetRoomById(id);
                if (obj != null)
                {
                    _context.Rooms.Remove(obj);
                    _context.SaveChanges();
                }
                else
                {
                    throw new Exception($"Room with ID {id} not found.");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                throw new Exception("An error occurred while deleting the room.", ex);
            }
        }

        public Room GetRoomById(int id)
        {
            try
            {
                return _context.Rooms.FirstOrDefault(r => r.Id == id);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                throw new Exception("An error occurred while retrieving the room.", ex);
            }
        }

        public List<Room> GetRooms()
        {
            try
            {
                return _context.Rooms.ToList();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                throw new Exception("An error occurred while retrieving the rooms.", ex);
            }
        
        }
    }
}
