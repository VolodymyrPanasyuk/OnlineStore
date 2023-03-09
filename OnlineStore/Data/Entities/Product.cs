using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.Data.Entities;

public class Product : BaseEntity
{
    [Required(ErrorMessage = "The Product name is required")]
    [StringLength(60)]
    public string Name { get; set; }

    [Required(ErrorMessage = "The Product description is required")]
    [StringLength(1000)]
    [DataType(DataType.MultilineText)]
    public string Description { get; set; }

    [Required(ErrorMessage = "The Price is required")]
    [Range(0, double.MaxValue, ErrorMessage = "The Price must be a positive number")]
    [DataType(DataType.Currency)]
    public double Price { get; set; }
    
    [Range(0, double.MaxValue, ErrorMessage = "The OldPrice must be a positive number")]
    [DataType(DataType.Currency)]
    public double? OldPrice { get; set; }
    
    [Required]
    public bool InStock { get; set; }

    [Required(ErrorMessage = "The ManufacturerId is required")]
    public Guid ManufacturerId { get; set; }
    
    [ForeignKey("ManufacturerId")]
    public Manufacturer Manufacturer { get; set; }

    [Required(ErrorMessage = "The CategoryId is required")]
    public Guid CategoryId { get; set; }
    
    [ForeignKey("CategoryId")]
    public Category Category { get; set; }
    
    public Guid? MainPhotoId { get; set; }
    
    [ForeignKey("MainPhotoId")]
    public Photo? MainPhoto { get; set; }

    [InverseProperty("Product")]
    public List<ProductCharacteristic>? ProductCharacteristics { get; set; }
    
    [InverseProperty("Product")]
    public virtual ICollection<Review>? Reviews { get; set; }
    
    [InverseProperty("Product")]
    public virtual ICollection<ShoppingCart>? ShoppingCarts { get; set; }
    
    [InverseProperty("Product")]
    public virtual ICollection<Wishlist>? Wishlists { get; set; }
    
    [InverseProperty("Product")]
    public virtual ICollection<OrderDetails>? OrderDetails { get; set; }
    
    [InverseProperty("Product")]
    public virtual ICollection<ProductPhoto>? ProductPhotos { get; set; }
}