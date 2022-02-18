

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTrackerAPI.EF.Models
{
    public class Category : ModelBase
    {
        public Category(
            string name,
            string discription
            )
        {
            Name = name;
            Discription = discription;
        }
        
        public string Name { get; set; }
        public string Discription { get; set; }


        //FK
        [ForeignKey("InvoiceItem")]
        public int InvoiceIItemId { get; set; }
    }
}
