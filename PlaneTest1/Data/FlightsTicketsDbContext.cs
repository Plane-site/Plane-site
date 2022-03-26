using Microsoft.EntityFrameworkCore;
using PlaneTest1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaneTest1.Data
{
    public class FlightsTicketsDbContext : DbContext
    {
        public DbSet<Flights> Flights { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
        public FlightsTicketsDbContext(DbContextOptions<FlightsTicketsDbContext> options) : base(options)
        {

        }
    }
}
