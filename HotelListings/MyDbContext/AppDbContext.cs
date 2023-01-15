using HotelListings.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelListings.MyDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Country>? Countries { get; set; }
        public DbSet<Hotel>? Hotels { get; set; }
    }
}