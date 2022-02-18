using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTrackerAPI.EF.Models
{
    public class InvoiceStatus : ModelBase
    {
        public InvoiceStatus(
            string invoiceStatusName,
            string discription
            )
        {
            InvoiceStatusName = invoiceStatusName;
            Discription = discription;
        }
        // Approved / Decline / Paid

        
        public string InvoiceStatusName { get; set; }
        public string Discription { get; set; }

        

        //FK
        [ForeignKey("Invoice")]
        public int InvoiceId { get; set; }
        
    }
}
