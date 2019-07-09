using HotSauceApp.Data;
using HotSauceApp.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotSauceApp.Models.Services
{
    public class ProductService : IProduct
    {
        private readonly HotSauceDbContext _context;

        public ProductService(HotSauceDbContext context)
        {
            _context = context;
        }
        public async Task CreateProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProduct(int id)
        {
            Product product = await _context.Products.FirstOrDefaultAsync(c => c.ID == id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            IEnumerable<Product> products = await _context.Products.ToListAsync();
            return products;
        }

        public async Task<Product> GetProduct(int id)
        {
            Product product = await _context.Products.FirstOrDefaultAsync(c => c.ID == id);
            return product;
        }

        public async Task UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}
