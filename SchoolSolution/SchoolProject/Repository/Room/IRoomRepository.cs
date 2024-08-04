using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolProject.Models;

namespace SchoolProject.Repository
{
    public interface IRoomRepository
    {
        public List<Room> GatAllRoom();
        public void Create(Room room);
        public void Delete(int id);
    }
}
