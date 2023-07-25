using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace RazorPayPaymentGateway.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Required]
        public string Name { get; set; }
        public string  Address { get; set; }
        [Display(Name = "Mobile Number")]
        public string MobileNumber { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        [Display(Name ="Date Of Birth")]
        public double DOB { get; set; }
        public string Image { get; set; }
    }
}
