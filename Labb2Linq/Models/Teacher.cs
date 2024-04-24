using System.ComponentModel.DataAnnotations;

namespace Labb2Linq.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }


        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
