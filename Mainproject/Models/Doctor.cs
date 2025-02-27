using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Mainproject.Models
{
    public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Doctor_Id { get; set; }
        [Required]
        public string Doctor_name { get; set; }
        public string Doctor_Email { get; set; }
        public string Doctor_Password { get; set; }



    }

}
