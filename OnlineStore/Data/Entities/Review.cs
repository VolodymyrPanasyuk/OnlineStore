using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.Data.Entities;

public class Review : BaseEntity
{
    [Required(ErrorMessage = "The CustomerId is required")]
    public Guid CustomerId { get; set; }
    
    [ForeignKey(("CustomerId"))]
    public Customer Customer { get; set; }
    
    [Required(ErrorMessage = "The ProductId is required")]
    public Guid ProductId { get; set; }
    
    [ForeignKey("ProductId")]
    public Product Product { get; set; }
    
    [Required(ErrorMessage = "The Rating is required")]
    [Range(1, 5, ErrorMessage = "The Rating value must be between 1 and 5")]
    public int Rating { get; set; }
    
    [StringLength(2000)]
    [DataType(DataType.MultilineText)]
    public string? Comment { get; set; }
    
    [StringLength(200)]
    [DataType(DataType.MultilineText)]
    public string? Advantages { get; set; }
    
    [StringLength(200)]
    [DataType(DataType.MultilineText)]
    public string? Disadvantages { get; set; }

    [Required]
    [DataType(DataType.DateTime)]
    public DateTime DateCreated { get; set; }
}