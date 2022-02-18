using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTrackerAPI.EF.Models
{
    public abstract class ModelBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        
        public DateTime? CreatedData { get; set; }
        public DateTime? UpdatedData { get; set; }
        public Boolean? IsDeleted { get; set; }


        //[Required]
        //public string? UpdatedBy { get; set; }
        //[Required]
        //public string? CreatedBy { get; set; }
        //[Required]
    }
}
