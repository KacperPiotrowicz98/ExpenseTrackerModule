using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTrackerAPI.EF.Models
{
    public class PurchaseTax : ModelBase
    {
        public PurchaseTax(
            string name,
            string description,
            int taxRatePercent

            )
        {
            Name = name;
            Description = description;
            TaxRatePercent = taxRatePercent;

        }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TaxRatePercent { get; set; }
        
   

        //Fk
        [ForeignKey("InvoiceItem")]
        public int InvoiceItemId { get; set; }
        
    }
}
