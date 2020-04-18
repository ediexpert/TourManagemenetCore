using System;
using AuthWithIdentity.DomainObjects;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthWithIdentity
{
    public class AppDbContext: IdentityDbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ApplicationUser> AppUsers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<Variant> Variants { get; set; }
        public DbSet<SeoMetadata> SeoMetadatas { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Basketitem> BasketItems { get; set; }
        public DbSet<Wish> Wishes { get; set; }
        //public DbSet<Tour> Tours { get; set; }
        //public DbSet<Variant> Variants { get; set; }
        //public DbSet<Booking> Bookings { get; set; }
        //public DbSet<BookingItem> BookingItems { get; set; }
        //public DbSet<Cart> Carts { get; set; }
        //public DbSet<CartItem> CartItems { get; set; }
    }
}
