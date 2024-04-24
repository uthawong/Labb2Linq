using System.ComponentModel.DataAnnotations;

namespace Labb2Linq.Models
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }
        public string ClassName { get; set; }


        public ICollection<Student>? Students { get; set; }  // ? = tillåter att Student är null 
    }
}