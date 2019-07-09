using HotSauceApp.Data;
using HotSauceApp.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotSauceApp.Models.Services
{
    public class CartProductService : ICartProduct
    {
        private readonly HotSauceDbContext _context;

        public CartProductService(HotSauceDbContext context)
        {
            _context = context;
        }
        public async Task CreateCartProduct(CartProduct cartProduct)
        {
            _context.CartProducts.Add(cartProduct);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCart(int cartID, int productID)
        {
            CartProduct cartProduct = await _context.CartProducts.FirstOrDefaultAsync(c => c.CartID == cartID && c.ProductID == productID);
            _context.CartProducts.Remove(cartProduct);
            await _context.SaveChangesAsync();
        }

        public async Task<CartProduct> GetCartProduct(int cartID, int productID)
        {
            CartProduct cartProduct = await _context.CartProducts.FirstOrDefaultAsync(c => c.CartID == cartID && c.ProductID == productID);
            return cartProduct;
        }

        public async Task<IEnumerable<CartProduct>> GetCartProductsByCart(int cartID)
        {
            IEnumerable<CartProduct> cartProductsRaw = await _context.CartProducts.ToListAsync();
            IEnumerable<CartProduct> cartProducts = cartProductsRaw.Where(c => c.CartID == cartID);
            return cartProducts;
        }

        public async Task UpdateCartProduct(CartProduct cartProduct)
        {
            _context.CartProducts.Update(cartProduct);
            await _context.SaveChangesAsync();
        }
    }
}
