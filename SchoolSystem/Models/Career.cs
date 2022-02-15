using System.ComponentModel.DataAnnotations;

namespace SchoolSystem.Models
{
    public class Career
    {
        [Key]
        public int CareerId { get; set; }

        [Required]
        public string Career_Name { get; set; }

        public string Career_Duration { get; set; }
        

        //RelantionShips
        public IList<Student> Students { get; set; }
    }
}
