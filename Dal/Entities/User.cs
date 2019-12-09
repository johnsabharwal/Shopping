using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Entities
{
    public class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
            ProductComments = new HashSet<ProductComment>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }
        public string Address { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastLogin { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<ProductComment> ProductComments { get; set; }
    }
}
