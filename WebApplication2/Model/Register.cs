using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Model
{
    public class Register
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string EmailId { get; set; }
        [Required]
        public string MobileNo { get; set; }
        [Required]
        public string Address { get; set; }
    }
}
