using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolProject.Context;
using SchoolProject.Models;

namespace SchoolProject.Repository
{
    public class RoomRepository : IRoomRepository
    {
        private readonly MyContext myContext;
        public RoomRepository(MyContext context)
        {
            myContext = context;
        }
        public List<Room> GatAllRoom()
        {
            List<Room> rooms = (from roomObj in myContext.Rooms
                                select roomObj).ToList();
            return rooms;
        }
        public void Create(Room room)
        {
            myContext.Rooms.Add(room);
            myContext.SaveChanges();

        }

        public void Delete(int id)
        {
            Room room = (from roomObj in myContext.Rooms 
                               where roomObj.room_Id == id
                               select roomObj).FirstOrDefault();
            myContext.Rooms.Remove(room);
            myContext.SaveChanges();
        }


    }
}
