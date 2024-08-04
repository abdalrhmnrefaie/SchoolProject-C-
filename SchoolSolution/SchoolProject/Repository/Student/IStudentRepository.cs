using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolProject.Models;

namespace SchoolProject.Repository
{
    public interface IStudentRepository
    {

        public List<Student> GetAllStudents();
        public void Create(Student student);
        public void Delete(int id);
        public void Register(int student_Id, int course_Id);

    }
}
