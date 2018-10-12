using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingService.Model
{
    public class BookingContext : DbContext
    {
        public BookingContext(DbContextOptions options) : base(options) { }
    
        public DbSet<Booking> Bookings {get;set;}
    }

}
