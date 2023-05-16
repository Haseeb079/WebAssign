using System.ComponentModel.DataAnnotations;

namespace WebAss.Models
{
    public class EstoreCustomerDetailForm
    {
        [Required]
        [Display(Name = "First Name")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Display(Name = "PhoneNumber")]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }
        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]

        public string City { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Address")]
        public string Address { get; set; }
    }
}