using System.ComponentModel.DataAnnotations;

namespace Labb2Linq.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }


        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}