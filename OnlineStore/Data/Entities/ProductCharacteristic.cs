using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.Data.Entities;

public class ProductCharacteristic : BaseEntity
{
    [Required(ErrorMessage = "The ProductId is required")]
    public Guid ProductId { get; set; }
    
    [ForeignKey("ProductId")]
    public Product Product { get; set; }

    [Required(ErrorMessage = "The CharacteristicId is required")]
    public Guid CharacteristicId { get; set; }
    
    [ForeignKey("CharacteristicId")]
    public Characteristic Characteristic { get; set; }

    [Required(ErrorMessage = "The Characteristic value is required")]
    [StringLength(50)]
    public string Value { get; set; }
}