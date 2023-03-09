using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.Data.Entities;

public class OrderDetails : BaseEntity
{
    [Required(ErrorMessage = "The OrderId is required")]
    public Guid OrderId { get; set; }

    [ForeignKey("OrderId")]
    public Order Order { get; set; }

    [Required(ErrorMessage = "The ProductId is required")]
    public Guid ProductId { get; set; }

    [ForeignKey("ProductId")]
    public Product Product { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int Quantity { get; set; }
    
    [Range(0, 100)]
    public double? Discount { get; set; }
}