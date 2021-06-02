using RRModels;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RRWebUI.Models
{

    public class CustomerVM
    {
        public CustomerVM(Customer customer)
        {
            CustomerId = customer.CustomerId;
            FirstName = customer.FirstName;
            LastName = customer.LastName;
            Email = customer.Email;
            Pin = customer.Pin;
        }

        public CustomerVM()
        {
        }
        public int CustomerId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [DisplayName("Email")]
        [Required]
        public string Email { get; set; }
        public int Pin { get; set; }
    }
}