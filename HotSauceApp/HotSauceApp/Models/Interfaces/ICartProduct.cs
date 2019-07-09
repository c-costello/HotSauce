using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotSauceApp.Models.Interfaces
{
    public interface ICartProduct
    {
        Task<CartProduct> GetCartProduct(int cartID, int productID);
        Task<IEnumerable<CartProduct>> GetCartProductsByCart(int cartID);
        Task CreateCartProduct(CartProduct cartProduct);
        Task UpdateCartProduct(CartProduct cartProduct);
        Task DeleteCart(int cartID, int productID);
    }
}
