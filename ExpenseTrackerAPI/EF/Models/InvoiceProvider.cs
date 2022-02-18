using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTrackerAPI.EF.Models
{
    public class InvoiceProvider : ModelBase
    {
        public InvoiceProvider(
            string? serviceProviderName,
            string description,
            string businessTaxNumber,
            double? serviceProviderBA
            )
        {
            ServiceProviderName = serviceProviderName;
            Description = description;
            BusinessTaxNumber = businessTaxNumber;
            ServiceProviderBA = serviceProviderBA;
        }
        [Required]
        public string? ServiceProviderName { get; set; }
        public string Description { get; set; }
        //NIP in Poland
        public string BusinessTaxNumber { get; set; }
        //ServiceProviderBankAccount
        [Required]
        public double? ServiceProviderBA { get; set; }


        //Forage Key
        [ForeignKey("InvoiceProviderAddress")]
        public int AddresId { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        


    }
}
