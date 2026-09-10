using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject2.Models
{
    public class Student 
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User User { get; set; }
       
        [Range(0, 4, ErrorMessage = "GPA must be between 0 and 4")]
        public double GPA { get; set; } = 0.0;
    }
}
