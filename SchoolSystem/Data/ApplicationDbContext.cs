using Microsoft.EntityFrameworkCore;
using SchoolSystem.Models;
using SchoolSystem.Models.JoinTables;

namespace SchoolSystem.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //StudentCourse
            modelBuilder.Entity<StudentCourse>().HasKey(sc => new
            {
                sc.StudentId,
                sc.CourseId
            });

            modelBuilder.Entity<StudentCourse>().HasOne(s => s.Student).WithMany(sc => sc.Student_Courses).HasForeignKey
                (s => s.StudentId);
            modelBuilder.Entity<StudentCourse>().HasOne(s => s.Course).WithMany(sc => sc.Student_Courses).HasForeignKey
                (s => s.CourseId);

            //StudentTeacher
            modelBuilder.Entity<StudentTeacher>().HasKey(sc => new
            {
                sc.StudentId,
                sc.TeacherId
            });

            modelBuilder.Entity<StudentTeacher>().HasOne(s => s.Student).WithMany(sc => sc.Student_Teachers).HasForeignKey
                (s => s.StudentId);
            modelBuilder.Entity<StudentTeacher>().HasOne(s => s.Teacher).WithMany(sc => sc.Student_Teachers).HasForeignKey
                (s => s.TeacherId);

            //TeacherCourse
            modelBuilder.Entity<TeacherCourse>().HasKey(sc => new
            {
                sc.CourseId,
                sc.TeacherId
            });

            modelBuilder.Entity<TeacherCourse>().HasOne(s => s.Course).WithMany(sc => sc.Teacher_Courses).HasForeignKey
                (s => s.CourseId);
            modelBuilder.Entity<TeacherCourse>().HasOne(s => s.Teacher).WithMany(sc => sc.Teacher_Courses).HasForeignKey
                (s => s.TeacherId);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Career> Careers { get; set; }
        public DbSet<Course> Courses { get; set; }
        

        //Join Tables
        public DbSet<StudentCourse> Student_Courses { get; set; }
        public DbSet<StudentTeacher> Student_Teachers { get; set; }
        public DbSet<TeacherCourse> Teacher_Courses { get; set; }
    }
}
