using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotSauceApp.Models.Interfaces
{
    public interface ICart
    {
        Task<Cart> GetCart(int id);
        Task<IEnumerable<Cart>> GetAllCarts();
        Task CreateCart(Cart cart);
        Task UpdateCart(Cart cart);
        Task DeleteCart(int id);
    }
}
