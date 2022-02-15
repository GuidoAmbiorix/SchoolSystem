using SchoolSystem.Data;
using SchoolSystem.Models.JoinTables;
using System.ComponentModel.DataAnnotations;

namespace SchoolSystem.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }

        [Required]
        public string Teacher_Name { get; set; }

        public string Teacher_Direction { get; set; }  
        
        public string Teacher_Phone { get; set; }

        public string Teacher_Horary { get; set; }


        //RelantionShips
        //Student-Teacher
        public IList<StudentTeacher> Student_Teachers { get; set; }

        //Teacher-Course
        public IList<TeacherCourse> Teacher_Courses { get; set; }

       
    }
}
