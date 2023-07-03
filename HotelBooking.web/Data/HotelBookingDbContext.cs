using HotelBooking.web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace HotelBooking.web.Data
{
    public class HotelBookingDbContext : DbContext
    {
        public HotelBookingDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<BlogPost>BlogPosts { get; set; }

        public DbSet <Tag> Tags { get; set; }
    }
}
