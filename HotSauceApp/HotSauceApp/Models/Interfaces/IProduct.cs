using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotSauceApp.Models.Interfaces
{
    public interface IProduct
    {
        Task<Product> GetProduct(int id);
        Task<IEnumerable<Product>> GetAllProducts();
        Task CreateProduct(Product product);
        Task UpdateProduct(Product product);
        Task DeleteProduct(int id);
    }
}
