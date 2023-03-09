using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Data.Entities;

public abstract class BaseEntity
{
    [Key]
    [Required]
    public Guid Id { get; set; }
}