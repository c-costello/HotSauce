using HotSauceApp.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotSauceApp.Models.Services
{
    public class CheckoutService
    {
        private readonly HotSauceDbContext _context;

        public CheckoutService(HotSauceDbContext context)
        {
            _context = context;
        }
        public async Task CreateCheckout(Checkout checkout)
        {
            _context.Checkouts.Add(checkout);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCheckout(int id)
        {
            Checkout checkout = await _context.Checkouts.FirstOrDefaultAsync(c => c.ID == id);
            _context.Checkouts.Remove(checkout);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Checkout>> GetAllCheckouts()
        {
            IEnumerable<Checkout> checkouts = await _context.Checkouts.ToListAsync();
            return checkouts;
        }

        public async Task<Checkout> GetCheckout(int id)
        {
            Checkout checkout = await _context.Checkouts.FirstOrDefaultAsync(c => c.ID == id);
            return checkout;
        }

        public async Task UpdateCheckout(Checkout checkout)
        {
            _context.Checkouts.Update(checkout);
            await _context.SaveChangesAsync();
        }
    }
}
