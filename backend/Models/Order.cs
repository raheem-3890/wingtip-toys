using System; 
using System.Collections.Generic; 
using System.ComponentModel; 
using System.ComponentModel.DataAnnotations; 
namespace WingtipToys.Api.Models 
{ 
    public class Order 
    { 
        public int OrderId { get; set; } 
        public DateTime OrderDate { get; set; } 
        public string Username { get; set; } 
        [Required(ErrorMessage = "User Name is required")] 
        [DisplayName("First Name")] 
        [StringLength(160)] 
        public string FirstName { get; set; } 
        [Required(ErrorMessage = "First Name is required")] 
        [DisplayName("Last Name")] 
        [StringLength(160)] 
        public string LastName { get; set; } 
        [Required(ErrorMessage = "Last is required")] 
        [StringLength(70)] 
        public string Address { get; set; } 
        [Required(ErrorMessage = "Address is required")] 
        [StringLength(40)] 
        public string City { get; set; } 
        [Required(ErrorMessage = "City is required")] 
        [StringLength(40)] 
        public string State { get; set; } 
        [Required(ErrorMessage = "State is required")] 
        [DisplayName("Postal Code")] 
        [StringLength(10)] 
        public string PostalCode { get; set; } 
        [Required(ErrorMessage = "Postal Code is required")] 
        [StringLength(40)] 
        public string Country { get; set; } 
        [Required(ErrorMessage = "Country is required")] 
        [StringLength(24)] 
        public string Phone { get; set; } 
        [Required(ErrorMessage = "Phone number is required")] 
        
        public string Email { get; set; }
        [DisplayName("Email Address")] 
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", 
            ErrorMessage = "Email is not valid.")] 
        [DataType(DataType.EmailAddress)]  
        [ScaffoldColumn(false)] 
        public decimal Total { get; set; } 
        [ScaffoldColumn(false)] 
        public string PaymentTransactionId { get; set; } 
        [ScaffoldColumn(false)] 
        public bool HasBeenShipped { get; set; } 
        public List<OrderDetail> OrderDetails { get; set; } 
    } 
} 