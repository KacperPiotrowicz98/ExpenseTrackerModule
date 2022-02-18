using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTrackerAPI.EF.Models
{
    public class Order : ModelBase
    {
        public Order(
            string name,
            string discription,
            int page,
            int qty,
            double price,
            double total
            )
        {
            Name = name;
            Discription = discription;
            Page = page;
            Qty = qty;
            Price = price;
            Total = total;
        }
       
        public string Name { get; set; }
        public string Discription { get; set; }
        public int Page { get; set; }
        // OrderFile - Blob i will add this later


        //Item
        public int Qty { get; set; }

        //Pay
        public double Price { get; set; }
        public double Total { get; set; }

        

        //ForeignKey
        [ForeignKey("UserAccount")]
        public int AccountId { get; set; }
        [ForeignKey("OrderStatus")]
        public int OrderStatusId { get; set; }
        [ForeignKey("InvoiceProvider")]
        public int InvoiceProviderId { get; set; }
        [ForeignKey("PaymentMethod")]
        public int PaymentMethodId { get; set; }
        [ForeignKey("InvoiceItem")]
        public int IncoiceItemId { get; set; }
        
        
        


    }
}
