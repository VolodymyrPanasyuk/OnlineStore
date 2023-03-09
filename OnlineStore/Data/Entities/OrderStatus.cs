using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.Data.Entities;

public class OrderStatus : BaseEntity
{
    [Required(ErrorMessage = "The Order status name is required")]
    [StringLength(30)]
    public string Name { get; set; }
    
    [InverseProperty("OrderStatus")]
    public virtual ICollection<Order>? Orders { get; set; }
}