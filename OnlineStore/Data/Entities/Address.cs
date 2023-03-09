using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.Data.Entities;

public class Address : BaseEntity
{
    [Required(ErrorMessage = "The Address name is required")]
    [StringLength(80)]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "The LocalityId is required")]
    public Guid LocalityId { get; set; }
    
    [ForeignKey("LocalityId")]
    public Locality Locality { get; set; }
    
    [InverseProperty("DefaultAddress")]
    public virtual IEnumerable<Customer>? Customers { get; set; }
    
    [InverseProperty("Address")]
    public virtual IEnumerable<DeliveryOffice>? DeliveryOffices { get; set; }
    
    [InverseProperty("Address")]
    public virtual IEnumerable<Order>? Orders { get; set; }
}