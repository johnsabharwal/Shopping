using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Model
{
    public class CreateOrder
    {
        public CreateOrder()
        {
            OrderDetails = new List<OrderDetails>();
        }
        [Required]
        public List<OrderDetails> OrderDetails { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public string PaymentMethod { get; set; }
    }
    public class OrderDetails
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Quanitity { get; set; }
    }
}
