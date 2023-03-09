using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.Data.Entities;

public class Payment : BaseEntity
{
    [Required(ErrorMessage = "The Payment name is required")]
    [StringLength(30)]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "The CustomerId is required")]
    public Guid CustomerId { get; set; }
    
    [ForeignKey("CustomerId")]
    public Customer Customer { get; set; }
    
    [Required(ErrorMessage = "The Card number is required")]
    [Range(1000000000000000, 9999999999999999, ErrorMessage = "The length of card number must be 16 digits")]
    [DataType(DataType.CreditCard)]
    public long CardNumber { get; set; }
    
    [Required(ErrorMessage = "The Card month is required")]
    [Range(1, 12, ErrorMessage = "The Month must be between 1 and 12")]
    public int Month { get; set; }
    
    [Required(ErrorMessage = "The Card year is required")]
    [Range(2022, 2100, ErrorMessage = "The Year must be between 2022 and 2100")]
    public int Year { get; set; }
    
    [Required(ErrorMessage = "The Card cvv is required")]
    [Range(100, 999, ErrorMessage = "The Cvv must be between 100 and 999")]
    public int Cvv { get; set; }
    
    [InverseProperty("Payment")]
    public virtual ICollection<Order>? Orders { get; set; }
}