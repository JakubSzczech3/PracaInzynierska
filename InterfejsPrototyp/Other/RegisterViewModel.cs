using System.ComponentModel.DataAnnotations;

namespace InterfejsPrototyp.Other
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Lastname is required.")]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Date of Birth is required.")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Incorrect email format.")]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [MaxLength(13)]
        [Phone(ErrorMessage = "Incorrect phone number")]
        public string PhoneNumber { get; set; }


        [Required(ErrorMessage = "Street and Number are required.")]
        [MaxLength(50)]
        public string StreetAddress { get; set; }

        [Required(ErrorMessage = "City is required.")]
        [MaxLength(30)]
        public string City { get; set; }

        [Required(ErrorMessage = "Postal Code is required.")]
        [MaxLength(20)]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "You have to choose a country.")]
        [MaxLength(50)]
        public string SelectedCountryName { get; set; } 

        [Required(ErrorMessage = "Password is required.")]
        [MinLength(6, ErrorMessage = "Password must be longer than 6 characters.")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords don't match.")]
        public string ConfirmPassword { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "You have to accept the terms.")]
        public bool AcceptsTerms { get; set; }
    }
}
