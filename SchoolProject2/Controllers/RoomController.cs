using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolProject2.Dbcontext;
using SchoolProject2.Models;
using SchoolProject2.repostory;

namespace SchoolProject2.Controllers
{
    public class RoomController : Controller
    {
        private readonly IRoomrepostory _roomrepostory;

        // GET: RoomController
        public ActionResult Index()
        {
            List<Room> rooms = _roomrepostory.GetRooms();
            return View(rooms);
        }

        // GET: RoomController/Details/5
        [HttpDelete]
        public ActionResult Details(int id)
        {
            _roomrepostory.Delete(id);
            return View();
        }

        // GET: RoomController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoomController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Room room)
        {
            try
            {
                _roomrepostory.Creation(room);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoomController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RoomController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoomController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                _roomrepostory.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
           
        }

        // POST: RoomController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
