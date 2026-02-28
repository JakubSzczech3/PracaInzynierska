using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace InterfejsPrototyp.Other
{
    [Table("Customers")]
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required, MaxLength(20)]
        public string FirstName { get; set; }

        [Required, MaxLength(20)]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        [Required, EmailAddress]
        [MaxLength(50)]
        public string Email { get; set; } 

        [Required, MaxLength(64)]
        public string PasswordHash { get; set; } 

        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        public ICollection<Address> Addresses { get; set; } = new List<Address>();
        public bool AcceptsTerms { get; set; }
        public string Role { get; set; } = "Buyer";
        public bool IsBanned { get; set; } = false; 

    }
}
