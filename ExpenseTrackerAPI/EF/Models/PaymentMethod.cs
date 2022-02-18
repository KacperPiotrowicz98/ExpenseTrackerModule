using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTrackerAPI.EF.Models
{
    public class PaymentMethod : ModelBase
    {
        public PaymentMethod(
            string? paymentMethodName,
            string? description,
            bool isOnline

            )
        {
            PaymentMethodName = paymentMethodName;
            Description = description;
            IsOnline = isOnline;
        }
        //create own type
        [Required]
        public string? PaymentMethodName { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public bool IsOnline { get; set; }

        

        //Forage Key
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        

    }
}
