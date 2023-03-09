using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.Data.Entities;

public class ProductPhoto : BaseEntity
{
    [Required(ErrorMessage = "The ProductId is required")]
    public Guid ProductId { get; set; }
    
    [ForeignKey("ProductId")]
    public Product Product { get; set; }
    
    [Required(ErrorMessage = "The PhotoId is required")]
    public Guid PhotoId { get; set; }
    
    [ForeignKey("PhotoId")]
    public Photo Photo { get; set; }
}