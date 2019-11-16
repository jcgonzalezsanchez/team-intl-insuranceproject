using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TS.WebApp.Models;

namespace TS.WebApp.Data
{
    public class TSContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<Insurance> Insurance { get; set; }
        public TSContext(DbContextOptions<TSContext> options)
            :base (options)
        {
            this.Database.EnsureCreated();
        }

    }
}
