using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentEnrollment.Models;

namespace StudentEnrollment.Data
{
    public class EnrollmentContext : IdentityDbContext
    {
        public EnrollmentContext(DbContextOptions<EnrollmentContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}