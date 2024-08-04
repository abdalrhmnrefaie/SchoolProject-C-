using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolProject.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int student_Id { get; set; }
        [MinLength(2)]
        [MaxLength(50)]
        public string student_Name { get; set; }
        public bool IsActive { get; set; }
        [Range(5,18)]
        public int student_Age { get; set; }

        public string Photo_Name { get; set; }

    }
}
