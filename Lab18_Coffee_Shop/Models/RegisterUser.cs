using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab18_Coffee_Shop.Models
{
    public class RegisterUser
    {
        [Required]
        [StringLength(20, MinimumLength =4, ErrorMessage ="Please enter a Username between 4 and 20 characters!")]
        public string UserName { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9{5,30}]+@[a-zA-A0-9{5,10}]+\.[a-zA-Z0-9{2,3}]+$", ErrorMessage = "Please enter a valid  email address!")]
        public string Email { get; set; }

        [Required]
        [StringLength(12, MinimumLength =6, ErrorMessage ="Please enter a password between 6 to 12 characters!")]
        public string Password { get; set; }

        [Required]
        public string Gender { get; set; }

        public int Age { get; set; }

        [RegularExpression(@"^\b\d{3}-\d{3}-\d{4}\b$", ErrorMessage = "Phone Number must be in correct format")]
        public string PhoneNumber { get; set; }
    }
}
