using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTrackerAPI.EF.Models
{
    public class InvoiceItem : ModelBase
    {
        public InvoiceItem(
            string itemName,
            string itemDescription,
            double itemAmountNetto,
            double itemAmountBrutto,
            double barcode,
            double internalCoder
            )
        {
            ItemName = itemName;
            ItemDescription = itemDescription;
            ItemAmountNetto = itemAmountNetto;
            ItemAmountBrutto = itemAmountBrutto;
            Barcode = barcode;
            InternalCoder = internalCoder;

        }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public double ItemAmountNetto { get; set; }
        public double ItemAmountBrutto { get; set; }
        public double Barcode { get; set; }
        public double InternalCoder { get; set; }

   
        //Forage Key
        [ForeignKey("PurchaseTax")]
        public int PurchaseTaxId { get; set; }
        [ForeignKey("Invoice")]
        public int InvoiceId { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        [ForeignKey("UOM")]
        public int UOMId { get; set; }
    }
}
