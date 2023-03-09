using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.Data.Entities;

public class Characteristic : BaseEntity
{
    [Required(ErrorMessage = "The Characteristic name is required")]
    [StringLength(60)]
    public string Name { get; set; }

    [InverseProperty("Characteristic")]
    public virtual ICollection<ProductCharacteristic>? ProductCharacteristics { get; set; }
}