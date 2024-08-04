using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolProject.Context;
using SchoolProject.Models;

namespace SchoolProject.Repository
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly MyContext myContext;
        public TeacherRepository(MyContext context) 
        {
            myContext = context;
        }
        public List<Teacher> GatAllTeacher()
        {
            List<Teacher> teachers = (from teacherObj in myContext.Teachers
                                      select teacherObj).ToList();
            return teachers;
        }
        public void Create(Teacher teacher)
        {
            myContext.Teachers.Add(teacher);
            myContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Teacher teacher = (from teacherObj in myContext.Teachers
                               where teacherObj.teacher_Id==id 
                               select teacherObj).FirstOrDefault();
            myContext.Teachers.Remove(teacher);
            myContext.SaveChanges();
        }

    }
}
