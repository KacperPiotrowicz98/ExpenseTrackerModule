using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTrackerAPI.EF.Models
{
    public class OrderStatus : ModelBase
    {
        public OrderStatus(
            string orderStatusName,
            string discription
            )
        {
            OrderStatusName = orderStatusName;
            Discription = discription;
        }
        // Approved / Decline / Received/ DeclineByVender
       
        public string OrderStatusName { get; set; }
        public string Discription { get; set; }
        
       


        //Foragine key
        [ForeignKey("Order")]
        public int OrderId { get; set; }

    }
}
