using SchoolSystem.Data.Enums;
using SchoolSystem.Models.JoinTables;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSystem.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        public string Student_Name { get; set; }

        public int Student_Age { get; set; }

        public int Student_Semester { get; set; }

        public StudentGender Student_Gender { get; set; }

        //RelationShips
        //Student-Career
        public int CareerId { get; set; }
        [ForeignKey("CareerId")]
        public Career Career { get; set; }

        //Student-Course
       public IList<StudentCourse>  Student_Courses { get; set; }

        //Student-Teacher
        public IList<StudentTeacher> Student_Teachers { get; set; }

    }
}
