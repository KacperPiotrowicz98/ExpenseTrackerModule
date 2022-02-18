

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTrackerAPI.EF.Models
{
    public class Brand : ModelBase
    {
        public Brand(
            int brandId,
            string name,
            string discription
            )
        {
            BrandId = brandId;
            Name = name;
            Discription = discription;
        }
        public int BrandId { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }



        //Fk
        [ForeignKey("InvoiceItem")]
        public int InvoiceItemId { get; set; }

    }
}
