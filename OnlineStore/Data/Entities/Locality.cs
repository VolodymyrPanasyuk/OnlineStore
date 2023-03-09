using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.Data.Entities;

public class Locality : BaseEntity
{
    [Required(ErrorMessage = "The Locality name is required")]
    [StringLength(60)]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "The RegionId is required")]
    public Guid RegionId { get; set; }
    
    [ForeignKey("RegionId")]
    public Region Region { get; set; }
    
    [InverseProperty("Locality")]
    public virtual IEnumerable<Address>? Addresses { get; set; }
}