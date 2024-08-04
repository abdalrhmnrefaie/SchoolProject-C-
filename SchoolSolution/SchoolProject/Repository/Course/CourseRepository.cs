using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolProject.Context;
using SchoolProject.Models;

namespace SchoolProject.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly MyContext myContext;
        public CourseRepository(MyContext context)
        {
            myContext = context;
        }
        public List<Course> GatAllCourse()
        {
            List<Course> courses = (from courseObj in myContext.Courses
                                select courseObj).ToList();
            return courses;
        }
        public void Create(Course course)
        {
            myContext.Courses.Add(course);
            myContext.SaveChanges();

        }

        public void Delete(int id)
        {
            Course course = (from courseObj in myContext.Courses
                         where courseObj.course_Id == id
                         select courseObj).FirstOrDefault();
            myContext.Courses.Remove(course);
            myContext.SaveChanges();
        }

    }
}
