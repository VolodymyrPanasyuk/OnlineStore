using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.Data.Entities;

public class Order : BaseEntity
{
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Number { get; set; }

    [Required(ErrorMessage = "The CustomerId is required")]
    public Guid CustomerId { get; set; }

    [ForeignKey("CustomerId")]
    public Customer Customer { get; set; }

    [Required]
    public bool CourierDelivery { get; set; }
    
    public Guid? DeliveryOfficeId { get; set; }

    [ForeignKey("DeliveryOfficeId")]
    public DeliveryOffice? DeliveryOffice { get; set; }
    
    public Guid? AddressId { get; set; }
    
    [ForeignKey("AddressId")]
    public Address? Address { get; set; }

    [Required]
    public bool OnlinePayment { get; set; }
    
    public Guid? PaymentId { get; set; }

    [ForeignKey("PaymentId")]
    public Payment? Payment { get; set; }
    
    public Guid DeliveryPriceId { get; set; }
    
    [ForeignKey("DeliveryPricingId")]
    public DeliveryPrice DeliveryPrice { get; set; }
    
    [StringLength(14, MinimumLength = 14, ErrorMessage = "The Tracking number length must be 14")]
    public string? TrackingNumber { get; set; }
    
    [Required(ErrorMessage = "The Order status Id is required")]
    public Guid OrderStatusId { get; set; }
    
    [ForeignKey("OrderStatusId")]
    public OrderStatus OrderStatus { get; set; }
    
    [Required]
    [DataType(DataType.DateTime)]
    public DateTime CreationDate { get; set; }
    
    [DataType(DataType.DateTime)]
    public DateTime? FinalizationDate { get; set; }
    
    [Range(0, double.MaxValue)]
    [DataType(DataType.Currency)]
    public double? TotalToPay { get; set; }
    
    [InverseProperty("Order")]
    public virtual ICollection<OrderDetails>? OrderDetails { get; set; }
}