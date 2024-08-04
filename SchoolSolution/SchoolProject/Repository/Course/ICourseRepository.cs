using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolProject.Models;

namespace SchoolProject.Repository
{
     public interface ICourseRepository
    {
        public List<Course> GatAllCourse();
        public void Create(Course course);
        public void Delete(int id);
    }
}
