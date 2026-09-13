using SchoolProject2.Models;

namespace SchoolProject2.repostory
{
    public interface IRoomrepostory
    {
        public List<Room> GetRooms();
        public Room GetRoomById(int id);
        public void Creation(Room room);
        public void Delete(int id);

    }
}
