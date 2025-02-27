using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Mainproject.Models
{
    public class User
    {
        [Key] // Primary Key
        public int UserID { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Role is required.")]
        [RegularExpression("Doctor|Patient", ErrorMessage = "Role must be either 'Doctor' or 'Patient'.")]
        public string Role { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [Phone(ErrorMessage = "Invalid phone number.")]
        public string Phone { get; set; }

        [StringLength(100, ErrorMessage = "Specialization cannot exceed 100 characters.")]
        public string Specialization { get; set; } // Only for doctors


    }
}
