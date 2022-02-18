using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTrackerAPI.EF.Models
{
    public class Invoice : ModelBase
    {

        public Invoice(
            string discription,
            string? invoiceNumber,
            int page,
            DateTime dateOfIssue,
            DateTime saleDate,
            DateTime paymentDeadline,
            DateTime? invoiceDueDate,
            string currency,
            double? invoiceAmountNetto,
            double? vatValue,
            double? invoiceAmountBrutto,
            double qty
            )
        {
            Discription = discription;
            InvoiceNumber = invoiceNumber;
            Page = page;
            DateOfIssue = dateOfIssue;
            SaleDate = saleDate;
            PaymentDeadline = paymentDeadline;
            InvoiceDueDate = invoiceDueDate;
            Currency = currency;
            InvoiceAmountNetto = invoiceAmountNetto;
            VatValue = vatValue;
            InvoiceAmountBrutto = invoiceAmountBrutto;
            Qty = qty;
        }
        // InvoiceFile - Blob i will add this later
        [Required]
        public string Discription { get; set; }
        public string? InvoiceNumber { get; set; }
        public int Page { get; set; }
        //Status of Invoice 
        
        //Date
        [Required]
        public DateTime DateOfIssue { get; set; }
        [Required]
        public DateTime SaleDate { get; set; }
        [Required]
        public DateTime PaymentDeadline { get; set; }
        [Required]
        public DateTime? InvoiceDueDate { get; set; }
        //Value
        public string Currency { get; set; }
        [Required]
        public double? InvoiceAmountNetto { get; set; }
        [Required]
        public double? VatValue { get; set; }
        [Required]
        public double? InvoiceAmountBrutto { get; set; }
        //Item
        public double Qty { get; set; }



        //Forage Key
        [ForeignKey("InvoiceStatus")]
        public int InvoiceStatusId { get; set; }
        [ForeignKey("InvoiceItem")]
        public int InvoiceItemId { get; set; }




    }
}
