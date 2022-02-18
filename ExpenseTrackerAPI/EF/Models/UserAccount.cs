using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTrackerAPI.EF.Models
{
    public class UserAccount :ModelBase
    {
        public UserAccount(

            string login,
            int password,
            int? accountingPeriod,
            string localisation,
            bool? isActive,
            string? userRole
            

            )
        {

            Login = login;
            Password = password;
            AccountingPeriod = accountingPeriod;
            Localisation = localisation;
            IsActive = isActive;
            UserRole = userRole;
            

        }


        [Required]
        public string Login { get; set; }
        [Required]
        //to do encrypt password
        public int Password { get; set; }
        public int? AccountingPeriod { get; set; }
        [Required]
        public string Localisation { get; set; }
        public bool? IsActive { get; set; }
        public string? UserRole { get; set; }
        



        //Forage Key

        [ForeignKey("Lenguage")]
        public int? LenguageId { get; set; }
        [ForeignKey("BankAccount")]
        public int? BankAccountId { get; set; }
        [ForeignKey("Order")]
        public int? OrderId { get; set; }



    }
}
