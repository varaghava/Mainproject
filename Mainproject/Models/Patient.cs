using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Mainproject.Models
{
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Patient_Id { get; set; }
        [Required]
        public string Patient_name { get; set; }
        public string Patient_Email { get; set; }
        public string Patient_Password { get; set; }



    }
}
