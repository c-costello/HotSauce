using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotSauceApp.Models.Interfaces
{
    public interface ICheckoutProduct
    {
        Task<CheckoutProduct> GetCheckoutProduct(int checkoutID, int productID);
        Task<IEnumerable<CheckoutProduct>> GetCheckoutProductsByCart(int cartID);
        Task CreateCheckoutProduct(CheckoutProduct checkoutProduct);
        Task UpdateCheckoutProduct(CheckoutProduct checkoutProduct);
        Task DeleteCheckoutProduct(int checkoutID, int productID);
    }
}
