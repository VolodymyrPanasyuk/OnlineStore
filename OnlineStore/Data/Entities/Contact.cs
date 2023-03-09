using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.Data.Entities;

public class Contact : BaseEntity
{
    [Required(ErrorMessage = "The CustomerId is required")]
    public Guid CustomerId { get; set; }
    
    [ForeignKey("CustomerId")]
    public Customer Customer { get; set; }
    
    [StringLength(15, MinimumLength = 10, ErrorMessage = "The length of the phone number must be between 10 and 15")]
    [DataType(DataType.PhoneNumber)]
    public string? Phone { get; set; }
    
    [StringLength(60, MinimumLength = 8, ErrorMessage = "The length of email must be between 8 and 60")]
    [DataType(DataType.EmailAddress)]
    public string? Email { get; set; }
}