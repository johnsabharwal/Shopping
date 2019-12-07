using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.DTO
{
    public class CreateOrderDTO
    {
        public CreateOrderDTO()
        {
            OrderDetails = new List<OrderDetails>();
        }
        public List<OrderDetails> OrderDetails { get; set; }
        public int UserId { get; set; }
        public string PaymentMethod { get; set; }
    }
    public class OrderDetails
    {
        public int ProductId { get; set; }
        public int Quanitity { get; set; }
    }
}
