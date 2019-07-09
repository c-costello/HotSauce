using HotSauceApp.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotSauceApp.Models.Services
{
    public class CheckoutProductService
    {
        private readonly HotSauceDbContext _context;

        public CheckoutProductService(HotSauceDbContext context)
        {
            _context = context;
        }
        public async Task CreateCheckoutProduct(CheckoutProduct checkoutProduct)
        {
            _context.CheckoutProducts.Add(checkoutProduct);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCheckout(int checkoutID, int productID)
        {
            CheckoutProduct checkoutProduct = await _context.CheckoutProducts.FirstOrDefaultAsync(c => c.CheckoutID == checkoutID && c.ProductID == productID);
            _context.CheckoutProducts.Remove(checkoutProduct);
            await _context.SaveChangesAsync();
        }

        public async Task<CheckoutProduct> GetCheckoutProduct(int checkoutID, int productID)
        {
            CheckoutProduct checkoutProduct = await _context.CheckoutProducts.FirstOrDefaultAsync(c => c.CheckoutID == checkoutID && c.ProductID == productID);
            return checkoutProduct;
        }

        public async Task<IEnumerable<CheckoutProduct>> GetCheckoutProductsByCheckout(int checkoutID)
        {
            IEnumerable<CheckoutProduct> checkoutProductsRaw = await _context.CheckoutProducts.ToListAsync();
            IEnumerable<CheckoutProduct> checkoutProducts = checkoutProductsRaw.Where(c => c.CheckoutID == checkoutID);
            return checkoutProducts;
        }

        public async Task UpdateCheckoutProduct(CheckoutProduct checkoutProduct)
        {
            _context.CheckoutProducts.Update(checkoutProduct);
            await _context.SaveChangesAsync();
        }
    }
}
