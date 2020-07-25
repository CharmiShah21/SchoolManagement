using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    public class Instructor
    {
        [Key]
        public int InstructorId { get; set; }
        public string InstructorName { get; set; }
        public string InstructorEmail { get; set; }
    }
}
