using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.Data.Entities;

public class Country : BaseEntity
{
    [Required(ErrorMessage = "The country name is required")]
    [StringLength(60)]
    public string Name { get; set; }
    
    [InverseProperty("Country")]
    public virtual IEnumerable<Region>? Regions { get; set; }
    
    [InverseProperty("Country")]
    public virtual IEnumerable<Manufacturer>? Manufacturers { get; set; }
}