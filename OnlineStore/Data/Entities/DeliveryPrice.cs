using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.Data.Entities;

public class DeliveryPrice : BaseEntity
{
    [Required(ErrorMessage = "The Delivery price name is required")]
    [StringLength(30)]
    public string Name { get; set; }

    [Required(ErrorMessage = "The DeliveryCompanyId is required")]
    public Guid DeliveryCompanyId { get; set; }
    
    [ForeignKey("DeliveryCompanyId")]
    public DeliveryCompany DeliveryCompany { get; set; }
    
    [Required(ErrorMessage = "The Price is required")]
    [Range(0, double.MaxValue, ErrorMessage = "The Price must be a positive number")]
    [DataType(DataType.Currency)]
    public double Price { get; set; }
    
    [InverseProperty("DeliveryPrice")]
    public virtual ICollection<Order>? Orders { get; set; }
}