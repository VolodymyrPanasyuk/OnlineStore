using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.Data.Entities;

public class DeliveryOffice : BaseEntity
{
    [Required(ErrorMessage = "The DeliveryCompanyId is required")]
    public Guid DeliveryCompanyId { get; set; }
    
    [ForeignKey("DeliveryCompanyId")]
    public DeliveryCompany DeliveryCompany { get; set; }
    
    [Required(ErrorMessage = "The AddressId is required")]
    public Guid AddressId { get; set; }
    
    [ForeignKey("AddressId")]
    public Address Address { get; set; }

    [Required(ErrorMessage = "The Postal index is required")]
    [Range(10000, 99999,ErrorMessage = "The Postal index must be between 10000 and 99999")]
    [DataType(DataType.PostalCode)]
    public int PostalIndex { get; set; }
    
    [Required(ErrorMessage = "The Start hour is required")]
    [Range(typeof(TimeOnly), "08:00", "22:00", ErrorMessage = "Start hour must be between 8:00 and 22:00.")]
    [DataType(DataType.Time)]
    public TimeOnly StartHour { get; set; }

    [Required(ErrorMessage = "The End hour is required")]
    [Range(typeof(TimeOnly), "08:00", "22:00", ErrorMessage = "End hour must be between 8:00 and 22:00.")]
    [DataType(DataType.Time)]
    public TimeOnly EndHour { get; set; }
    
    [InverseProperty("DeliveryOffice")]
    public virtual ICollection<Order>? Orders { get; set; }
    
    [InverseProperty("DefaultDeliveryOffice")]
    public virtual ICollection<Customer>? Customers { get; set; }
}