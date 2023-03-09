using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.Data.Entities;

public class Wishlist : BaseEntity
{
    [Required(ErrorMessage = "The CustomerId is required")]
    public Guid CustomerId { get; set; }

    [ForeignKey("CustomerId")]
    public virtual Customer Customer { get; set; }

    [Required(ErrorMessage = "The ProductId is required")]
    public Guid ProductId { get; set; }

    [ForeignKey("ProductId")]
    public Product Product { get; set; }
}