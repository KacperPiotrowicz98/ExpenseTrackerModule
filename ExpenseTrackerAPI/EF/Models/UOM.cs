using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTrackerAPI.EF.Models
{
    public class UOM : ModelBase
    {
        public UOM(
            string uomName,
            string discription
            )
        {
            UomName = uomName;
            Discription = discription;
        }
        
        public string UomName { get; set; }
        public string Discription { get; set; }

       

        //Fk
        [ForeignKey("InvoiceItem")]
        public int InvoiceItemId { get; set; }

    }
}

