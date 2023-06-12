using System.ComponentModel.DataAnnotations;

namespace RailwayManagerBlazor.Models
{
    public class UserRegistration
	{
        [Required]
        [Display(Name = "ion.popescu@email.com")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Ion")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Popescu")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Parolă cu o majusculă, un număr, un caracter special")]
        public string Password { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
	}
}
