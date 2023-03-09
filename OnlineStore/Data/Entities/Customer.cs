using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace OnlineStore.Data.Entities;

public class Customer : BaseEntity
{
    [Required]
    public string UserId { get; set; }
    
    [ForeignKey("UserId")]
    public virtual IdentityUser User { get; set; }

    [StringLength(30)]
    public string? FirstName { get; set; }
    
    [StringLength(30)]
    public string? LastName { get; set; }
    
    [Range(typeof(DateTime), "1/1/1901", "12/31/2010",
        ErrorMessage = "The Birth date must be between 1901 and 2010")]
    [DataType(DataType.Date)]
    public DateOnly? BirthDate { get; set; }
    
    public Guid? DefaultAddressId { get; set; }
    
    [ForeignKey("DefaultAddressId")]
    public Address? DefaultAddress { get; set; }

    public Guid? DefaultDeliveryOfficeId { get; set; }
    
    [ForeignKey("DefaultDeliveryOfficeId")]
    public DeliveryOffice? DefaultDeliveryOffice { get; set; }
    
    [InverseProperty("Customer")]
    public virtual ICollection<Contact>? Contacts { get; set; }
    
    [InverseProperty("Customer")]
    public virtual ICollection<Payment>? Payments { get; set; }
    
    [InverseProperty("Customer")]
    public virtual ICollection<Review>? Reviews { get; set; }
    
    [InverseProperty("Customer")]
    public virtual ICollection<Wishlist>? Wishlists { get; set; }
    
    [InverseProperty("Customer")]
    public virtual ICollection<ShoppingCart>? ShoppingCarts { get; set; }
    
    [InverseProperty("Customer")]
    public virtual ICollection<Order>? Orders { get; set; }
}