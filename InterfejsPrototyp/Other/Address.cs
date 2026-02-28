using System.ComponentModel.DataAnnotations;

namespace InterfejsPrototyp.Other
{
    public class Address
    {
        public int AddressId { get; set; }

        [Required, MaxLength(50)]
        public string StreetAddress { get; set; }

        [Required, MaxLength(30)]
        public string City { get; set; }

        [Required, MaxLength(20)]
        public string PostalCode { get; set; }

        [Required, MaxLength(50)]
        public string CountryName { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
