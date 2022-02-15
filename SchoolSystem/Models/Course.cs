using SchoolSystem.Models.JoinTables;
using System.ComponentModel.DataAnnotations;

namespace SchoolSystem.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        public string Course_Name { get; set; }

        public int Course_Credits { get; set; }

        //RelantionShips
        //Student-Course
        public IList<StudentCourse> Student_Courses { get; set; }

        //Teacher-Course
        public IList<TeacherCourse> Teacher_Courses { get; set; }

    }
}
