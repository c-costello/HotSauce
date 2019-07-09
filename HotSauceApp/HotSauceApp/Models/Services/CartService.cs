using HotSauceApp.Data;
using HotSauceApp.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotSauceApp.Models.Services
{
    public class CartService : ICart
    {
        private readonly HotSauceDbContext _context;

        public CartService(HotSauceDbContext context)
        {
            _context = context;
        }
        public async Task CreateCart(Cart cart)
        {
            _context.Carts.Add(cart);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCart(int id)
        {
            Cart cart = await _context.Carts.FirstOrDefaultAsync(c => c.ID == id);
            _context.Carts.Remove(cart);
            await _context.SaveChangesAsync();
        }
        
        public async Task<IEnumerable<Cart>> GetAllCarts()
        {
            IEnumerable<Cart> carts = await _context.Carts.ToListAsync();
            return carts;
        }

        public async Task<Cart> GetCart(int id)
        {
            Cart cart = await _context.Carts.FirstOrDefaultAsync(c => c.ID == id);
            return cart;
        }

        public async Task UpdateCart(Cart cart)
        {
            _context.Carts.Update(cart);
            await _context.SaveChangesAsync();
        }
    }
}
