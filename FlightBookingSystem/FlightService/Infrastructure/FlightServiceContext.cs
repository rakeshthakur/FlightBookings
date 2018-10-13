using FlightService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightService.Infrastructure
{
    public class FlightServiceContext : DbContext
    {

        public FlightServiceContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<FlightDetails> FlightDetails { get; set; }

        public DbSet<FlightSchedules> FlightSchedules { get; set; }
    }
}
