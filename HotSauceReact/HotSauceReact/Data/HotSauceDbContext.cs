using HotSauceReact.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotSauceReact.Data
{
    public class HotSauceDbContext : DbContext
    {
        public HotSauceDbContext(DbContextOptions<HotSauceDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CartProduct>().HasKey(ce => new { ce.CartID, ce.ProductTypeID });

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Shirt> Shirts { get; set; }
        public DbSet<Sauce> Sauces { get; set; }
        public DbSet<CartProduct> CartProducts { get; set; }
        public DbSet<Cart> Carts { get; set; }

    }
}
