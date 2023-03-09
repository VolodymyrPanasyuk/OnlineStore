using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.Data.Entities;

public class ShoppingCart : BaseEntity
{
    [Required(ErrorMessage = "The CustomerId is required")]
    public Guid CustomerId { get; set; }

    [ForeignKey("CustomerId")]
    public Customer Customer { get; set; }

    [Required(ErrorMessage = "The ProductId is required")]
    public Guid ProductId { get; set; }

    [ForeignKey("ProductId")]
    public Product Product { get; set; }

    [Required(ErrorMessage = "The Quantity is required")]
    [Range(0, Int32.MaxValue, ErrorMessage = "The Quantity must be a positive value")]
    public int Quantity { get; set; }
}