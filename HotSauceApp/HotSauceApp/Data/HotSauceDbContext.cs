using HotSauceApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotSauceApp.Data
{
    public class HotSauceDbContext : DbContext
    {
        public HotSauceDbContext(DbContextOptions<HotSauceDbContext> options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CartProduct>().HasKey(ce => new { ce.CartID, ce.ProductID });
            modelBuilder.Entity<CheckoutProduct>().HasKey(ce => new { ce.CheckoutID, ce.ProductID });

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<CartProduct> CartProducts { get; set; }
        public DbSet<Cart> Carts { get; set;}
        public DbSet<CheckoutProduct> CheckoutProducts { get; set; }
        public DbSet<Checkout> Checkouts { get; set; }

    }
}
