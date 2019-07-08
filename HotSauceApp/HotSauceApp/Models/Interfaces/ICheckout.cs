using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotSauceApp.Models.Interfaces
{
    public interface ICheckout
    {
        Task<Checkout> GetCheckout(int id);
        Task<IEnumerable<Checkout>> GetAllCheckouts();
        Task CreateCheckout(Checkout checkout);
        Task UpdateCheckout(Checkout checkout);
        Task DeleteCheckout(int id);
    }
}
