using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTrackerAPI.EF.Models
{
    public class InvoiceProviderAddress : ModelBase
    {
        public InvoiceProviderAddress(
            string? country,
            string? city,
            string? street,
            string? zipCode,
            string email,
            int phoneNumber
            )
        {
            Country = country;
            City = city;
            Street = street;
            ZipCode = zipCode;
            Email = email;
            PhoneNumber = phoneNumber;
        }
        
        [Required]
        public string? Country { get; set; }
        [Required]
        public string? City { get; set; }
        [Required]
        public string? Street { get; set; }
        [Required]
        public string? ZipCode { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }

        

        //Forage Key
        [ForeignKey("InvoiceProvider")]
        public int InvoiceProviderId { get; set; }
    }
}
