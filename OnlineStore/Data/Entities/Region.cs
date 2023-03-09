using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.Data.Entities;

public class Region : BaseEntity
{
    [Required(ErrorMessage = "The Region name is required")]
    [StringLength(60)]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "The CountryId is required")]
    public Guid CountryId { get; set; }
    
    [ForeignKey("CountryId")]
    public Country Country { get; set; }
    
    [InverseProperty("Region")]
    public virtual ICollection<Locality>? Localities { get; set; }
}