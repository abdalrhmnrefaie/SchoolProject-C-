﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolProject.Models
{
    public class StudentCourse
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int studentCourse_Id { get; set; }

        public int student_Id { get; set; }
        public Student Student { get; set; }

        public int course_Id { get; set; }
        public Course Course { get; set; }


    }
}
