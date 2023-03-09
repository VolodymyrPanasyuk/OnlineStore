using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.Data.Entities;

public class DeliveryCompany : BaseEntity
{
    [Required(ErrorMessage = "The Delivery Company name is required")]
    [StringLength(60)]
    public string Name { get; set; }
    
    public Guid? PhotoId { get; set; }
    
    [ForeignKey("PhotoId")]
    public Photo? Photo { get; set; }

    [InverseProperty("DeliveryCompany")]
    public virtual ICollection<DeliveryPrice>? DeliveryPrices { get; set; }
    
    [InverseProperty("DeliveryCompany")]
    public virtual ICollection<DeliveryOffice>? DeliveryOffices { get; set; }
}