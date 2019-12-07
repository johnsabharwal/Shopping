using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Entities
{
   public class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }

        public int UserId { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        public decimal Total { get; set; }
        public string OrderStatus { get; set; }
        public User user { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
