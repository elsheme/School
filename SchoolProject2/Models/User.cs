using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SchoolProject2.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required]
        [MaxLength(100)]
        [MinLength(3)]
        public string Name { get; set; }
        [EmailAddress]   
        public string Email { get; set; }

        [Required]
        [MaxLength(255)]
        public string Password { get; set; }

        private string _role = "Student";
        public string Role { get => _role; set
            {
                if (value == "Student" || value == "Teacher" || value == "Admin")
                {
                    _role = value;
                }
                else { 
                
                    throw new ArgumentException("Role must be either 'Student', 'Teacher', or 'Admin'");
                }

            } 
        }

                
             

        public bool IsActive { get; set; } = false;
    }
}
