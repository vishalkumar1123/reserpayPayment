using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPayPaymentGateway.Models
{
    public class OrderEntity
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string CustomerName { get; set; }
        public string    Email { get; set; }  
        public string Address { get; set; }
        public string Mobile { get; set; }
        [Display(Name ="Total Amount")]
        public double   TotalAmount { get; set; }
        [NotMapped]
        public string TransactionId { get; set; }
        [NotMapped]
        public string OrderId { get; set; }
    }
}
