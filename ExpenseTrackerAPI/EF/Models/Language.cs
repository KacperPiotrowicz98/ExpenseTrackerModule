using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTrackerAPI.EF.Models
{
    public class Language : ModelBase
    {
        public Language(
            string languageName,
            string languageDiscription
            )
        {
            LanguageName = languageName;
            LanguageDiscription = languageDiscription;
        }
        public string LanguageName { get; set; }
        public string LanguageDiscription { get; set; }
        
        //FK
        [ForeignKey("UserAccount")]
        public int AccountID { get; set; }
    }
}
