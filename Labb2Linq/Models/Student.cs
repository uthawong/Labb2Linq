using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Labb2Linq.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        [ForeignKey("Class")]
        public int FkClassId { get; set; }
        public Class? Class { get; set; }
        public ICollection <Enrollment>? Enrollments { get; set; }
    }
}
