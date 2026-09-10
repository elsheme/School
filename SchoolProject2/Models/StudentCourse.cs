using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject2.Models
{
    public class StudentCourse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentCourseId { get; set; }
        [Column("Id")]
        public int StudentId { get; set; }
        public Student Student { get; set; }

        [Column("IdCourse")]
        public int CourseId { get; set; }
        public Course Course { get; set; }

    }
}
