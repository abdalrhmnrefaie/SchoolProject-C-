using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolProject.Models
{
    public class Room
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int room_Id { get; set; }
        [MinLength(2)]
        [MaxLength(50)]
        public string room_Name { get; set; }

    }
}
