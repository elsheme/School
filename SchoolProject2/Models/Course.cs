using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject2.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCourse { get; set; }
        public string Name { get; set; }
        [Column("Id")]
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        
        public int Capacity { get; set; } = 0;
    }
}
