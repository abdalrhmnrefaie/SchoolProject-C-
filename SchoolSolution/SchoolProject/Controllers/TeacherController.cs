using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.Models;
using SchoolProject.Repository;

namespace SchoolProject.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherRepository teacherRepository;
        public TeacherController(ITeacherRepository teacherRepo) 
        {
            teacherRepository = teacherRepo;
        }

        [HttpGet]
        public ActionResult  Index()
        {
            List<Teacher> teacherList = teacherRepository.GatAllTeacher();
            return View(teacherList);
        }
        [HttpGet]
        public ViewResult Create() 
        {
            return View();

        }
        [HttpPost]
        public ActionResult Create(Teacher teacher)
        {
            if (teacher != null) 
            {
                teacherRepository.Create(teacher);
            }
            List<Teacher> teacherList = teacherRepository.GatAllTeacher();

            return View("Index", teacherList);

        }
        public ActionResult Delete(int id)
        {
            if (id > 0)
            {
                teacherRepository.Delete(id);
            }
            List<Teacher> teacherList = teacherRepository.GatAllTeacher();

            return View("Index", teacherList);
        }
    }
}
