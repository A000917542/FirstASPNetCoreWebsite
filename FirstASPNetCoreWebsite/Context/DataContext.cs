using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstASPNetCoreWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstASPNetCoreWebsite.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
