using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolProject.Models;

namespace SchoolProject.Repository
{
    public interface ITeacherRepository
    {
        public List<Teacher> GatAllTeacher();
        public void Create(Teacher teacher);
        public void Delete(int id);
    }
}
