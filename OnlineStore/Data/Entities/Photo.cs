using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.Data.Entities;

public class Photo : BaseEntity
{
    [Required(ErrorMessage = "The Photo url is required")]
    [DataType(DataType.ImageUrl)]
    public string Url { get; set; }
    
    [InverseProperty("Photo")]
    public virtual IEnumerable<DeliveryCompany>? DeliveryCompanies { get; set; }

    [InverseProperty("Photo")]
    public virtual IEnumerable<ProductPhoto>? ProductPhotos { get; set; }

    [InverseProperty("MainPhoto")]
    public virtual IEnumerable<Product>? Products { get; set; }
}