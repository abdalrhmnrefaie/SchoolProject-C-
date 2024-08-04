using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.Models;
using SchoolProject.Repository;

namespace SchoolProject.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository courseRepository;
        private readonly ITeacherRepository teacherRepository;

        public CourseController(ICourseRepository courseRepo , ITeacherRepository teacherRepo)
        {

            courseRepository = courseRepo;
            teacherRepository = teacherRepo;
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<Course> courseList = courseRepository.GatAllCourse();
            return View(courseList);
        }
        [HttpGet]
        public ViewResult Create()
        {
            List<Teacher> teacherList = teacherRepository.GatAllTeacher();

            return View(teacherList);

        }
        [HttpPost]
        public ActionResult Create(Course course)
        {
            if (course != null)
            {
                courseRepository.Create(course);
            }
            List<Course> courseList = courseRepository.GatAllCourse();

            return View("Index",courseList);

        }
        public ActionResult Delete(int id)
        {
            if (id > 0)
            {
                courseRepository.Delete(id);
            }
            List<Course> courseList = courseRepository.GatAllCourse();

            return View("Index", courseList);
        }
    }
}
