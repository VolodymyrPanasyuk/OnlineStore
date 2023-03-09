using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.Data.Entities;

public class Category : BaseEntity
{
    [Required(ErrorMessage = "The Category name is required")]
    [StringLength(60)]
    public string Name { get; set; }
    
    [InverseProperty("Category")]
    public virtual ICollection<Product>? Products { get; set; }
}