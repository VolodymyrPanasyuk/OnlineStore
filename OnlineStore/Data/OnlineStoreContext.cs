using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Data.Entities;

namespace OnlineStore.Data;

public class OnlineStoreContext : IdentityDbContext
{
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Characteristic> Characteristics { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<DeliveryCompany> DeliveryCompanies { get; set; }
    public DbSet<DeliveryOffice> DeliveryOffices { get; set; }
    public DbSet<DeliveryPrice> DeliveryPrices { get; set; }
    public DbSet<Locality> Localities { get; set; }
    public DbSet<Manufacturer> Manufacturers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetails> OrderDetails { get; set; }
    public DbSet<OrderStatus> OrderStatuses { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Photo> Photos { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductCharacteristic> ProductCharacteristics { get; set; }
    public DbSet<ProductPhoto> ProductPhotos { get; set; }
    public DbSet<Region> Regions { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    public DbSet<Wishlist> Wishlists { get; set; }

    public OnlineStoreContext(){}
    
    public OnlineStoreContext(DbContextOptions<OnlineStoreContext> options) : base(options) {}
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("DataSource=OnlineStoreDB.db;Cache=Shared");
        }
    }
}