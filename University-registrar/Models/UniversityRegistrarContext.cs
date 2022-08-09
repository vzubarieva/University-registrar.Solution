using Microsoft.EntityFrameworkCore;

namespace UniversityRegistrar.Models
{
    public class UniversityRegistrarContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<CourseStudent> CourseStudents { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<DepartmentCourse> DepartmentCourses { get; set; }

        public UniversityRegistrarContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
