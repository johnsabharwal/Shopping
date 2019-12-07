using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.DTO
{
    public class OrderDetailDTO
    {
        public OrderDetailDTO()
        {
            OrderDetails = new List<OrderDetailsDTO>();
        }
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }

        public int UserId { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        public decimal Total { get; set; }
        public string OrderStatus { get; set; }
        public List<OrderDetailsDTO> OrderDetails { get; set; }
    }
    public class OrderDetailsDTO
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal ShippingCost { get; set; }

    }
}