using System.ComponentModel.DataAnnotations;

namespace Contact.Models
{
    public class PhoneContact
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(20)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Lonestar Number")]
        public string LonestarNumber { get; set; }

        [Required]
        [StringLength(20)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Orange Number")]
        public string OrangeNumber { get; set; }

        [Required]
        [StringLength(150)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
