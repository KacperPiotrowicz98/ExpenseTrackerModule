using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTrackerAPI.EF.Models
{
    public class Payments : ModelBase
    {
        public Payments(
            string? paymentsName,
            double? price,
            bool? paymentStatus,
            DateTime? dpayments
            )
        {
            PaymentsName = paymentsName;
            Price = price;
            PaymentStatus = paymentStatus;
            Dpayments = dpayments;
        }
        [Required]
        public string? PaymentsName { get; set; }
        [Required]
        public double? Price { get; set; }
        [Required]
        public bool? PaymentStatus { get; set; }
        [Required]
        public DateTime? Dpayments { get; set; }





        //Forage Key
        [ForeignKey("InvoiceProvider")]
        public int InvoiceProviderId { get; set; }
            
        [ForeignKey("PaymentMethod")]
        public int PaymentMethodId { get; set; }
        
        [ForeignKey("Invoice")]
        public int InvoiceId { get; set; }




    }
}
