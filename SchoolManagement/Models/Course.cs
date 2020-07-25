using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }

        [ForeignKey("Fee")]
        public int FeeId { get; set; }
        public Fee Fee { get; set; }

        [ForeignKey("Instructor")]
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
    }
}
