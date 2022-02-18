

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTrackerAPI.EF.Models
{
    public class BankAccount : ModelBase
    {
        public BankAccount(
            string? bankName,
            double? accountNumber
            )
        {
            BankName = bankName;
            AccountNumber = accountNumber;

        }
        [Required]
        public string? BankName { get; set; }
        [Required]
        public double? AccountNumber { get; set; }


        //Forage Key
        [ForeignKey("Account")]
        public int AccountId { get; set; }
        
    }
}
