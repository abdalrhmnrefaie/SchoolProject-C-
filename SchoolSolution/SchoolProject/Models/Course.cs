using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolProject.Models
{
    public class Course
    {


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int course_Id { get; set; }
        [MinLength(2)]
        [MaxLength(50)]
        public string course_Name { get; set; }
        public int teacher_Id { get; set; }
        public Teacher Teacher { get; set; }
        [Range(0, 25)]
        public int course_Capicity { get; set; }

    }
}
