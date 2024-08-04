using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.Models;
using SchoolProject.Repository;

namespace SchoolProject.Controllers
{
    public class RoomController : Controller
    {
        private readonly IRoomRepository roomRepository ;
        public RoomController(IRoomRepository roomRepo)
        {
            roomRepository = roomRepo;
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<Room> roomList = roomRepository.GatAllRoom();
            return View(roomList);
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Create(Room room)
        {
            if (room != null)
            {
                roomRepository.Create(room);
            }
            List<Room> roomList = roomRepository.GatAllRoom();

            return View("Index",roomList);

        }
        public ActionResult Delete(int id)
        {
            if (id > 0)
            {
                roomRepository.Delete(id);
            }
            List<Room> roomList = roomRepository.GatAllRoom();

            return View("Index", roomList);
        }
    }
}
