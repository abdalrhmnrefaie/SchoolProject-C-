using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.Models;
using SchoolProject.Models.StudentCourseVM;
using SchoolProject.Repository;

namespace SchoolProject.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository studentRepository;
        private readonly ICourseRepository courseRepository;
        private readonly IHostingEnvironment enviroment;

        public StudentController(IStudentRepository studentRepo , ICourseRepository courseRepo , IHostingEnvironment enviro)
        {
            studentRepository = studentRepo;

            courseRepository = courseRepo;

            enviroment = enviro;
        }

        //List Of Students .
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.username = "Abdalrhmn Refaie";
            ViewData["test"] = "Java Developer";
            List<Student> StudList = studentRepository.GetAllStudents();
            return View(StudList);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student ,IFormFile studentPhoto)
        {
            var wwwroot = enviroment.WebRootPath + "/StudentPictures/";
            //Guid guid = new Guid();
            Guid guid = Guid.NewGuid();
            string fullpath = System.IO.Path.Combine(wwwroot, guid+ studentPhoto.FileName);

            using (var fileStream = new FileStream(fullpath, FileMode.Create))
            {
                studentPhoto.CopyTo(fileStream);

            };

            student.Photo_Name = guid + studentPhoto.FileName;
            studentRepository.Create(student);
            List<Student> StudList = studentRepository.GetAllStudents();
            return View("Index",StudList);
        }
        public ViewResult Delete(int id)
        {
            studentRepository.Delete(id);
            List<Student> StudList = studentRepository.GetAllStudents();
            return View("Index", StudList);
        }

        [HttpGet]
        public ActionResult Register()
        {
            /*
             *    if(TempData["test"] != null)
                {
                    int var = (int)TempData["test"];
                }
             */
            StudentCourseVm data = new StudentCourseVm();
            data.Courses = courseRepository.GatAllCourse();
            data.Students = studentRepository.GetAllStudents();
            return View(data);
        }
        [HttpPost]
        public ActionResult Register(int student_Id, int course_Id)
        {
          //  TempData["test"] = 20;
            studentRepository.Register(student_Id, course_Id);
            return RedirectToAction("Register");
        }

    }
}
