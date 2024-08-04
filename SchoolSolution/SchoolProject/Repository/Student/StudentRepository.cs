using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolProject.Context;
using SchoolProject.Models;

namespace SchoolProject.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly MyContext myDbConnection;
        public StudentRepository(MyContext myContext)
        {

            myDbConnection = myContext;
        }

        public List<Student> GetAllStudents()
        {
            try
            {
                List<Student> students = (from stdsObj in myDbConnection.Students
                                          select stdsObj).ToList();
                return students;
            }
            catch (Exception ex)
            {
                return null ;
            }

        }

        public void Create(Student student)
        {
            myDbConnection.Students.Add(student);
            myDbConnection.SaveChanges();
        }

        public void Delete(int id)
        {
            Student student = (from stdsObj in myDbConnection.Students
                               where stdsObj.student_Id == id
                               select stdsObj).FirstOrDefault();
            myDbConnection.Students.Remove(student);
            myDbConnection.SaveChanges();
        }

        public void Register(int student_Id, int course_Id)
        {
            myDbConnection.StudentCourses.Add(new StudentCourse { course_Id = course_Id, student_Id = student_Id });
            myDbConnection.SaveChanges();
        }
    }
}
