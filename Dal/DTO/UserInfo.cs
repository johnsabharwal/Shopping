using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.DTO
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }
        public string Address { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
