using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.Data.Entities;

public class Manufacturer : BaseEntity
{
    [Required(ErrorMessage = "The Manufacturer name is required")]
    [StringLength(60)]
    public string Name { get; set; }
    
    public Guid? CountryId { get; set; }
    
    [ForeignKey("CountryId")]
    public Country? Country { get; set; }
    
    [InverseProperty("Manufacturer")]
    public virtual ICollection<Product>? Products { get; set; }
}