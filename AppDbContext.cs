using System;
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

        //public DbSet<Tour> Tours { get; set; }
        //public DbSet<Variant> Variants { get; set; }
        //public DbSet<Booking> Bookings { get; set; }
        //public DbSet<BookingItem> BookingItems { get; set; }
        //public DbSet<Cart> Carts { get; set; }
        //public DbSet<CartItem> CartItems { get; set; }
    }
}
