using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolProject.Models
{
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int teacher_Id { get; set; }
        [MinLength(2)]
        [MaxLength(50)]
        public string teacher_Name { get; set; }
        [Range(22, 40)]
        public int teacher_Age { get; set; }
    }
}

