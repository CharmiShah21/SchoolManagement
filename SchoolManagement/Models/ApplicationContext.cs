using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SchoolManagement.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Fee> Fees { get; set; }

        public DbSet<Instructor> Instructors { get; set; }
    }
}
