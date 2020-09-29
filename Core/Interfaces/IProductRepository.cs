using System.Threading.Tasks;
using System.Collections.Generic;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetproductByIdAsync(int id);
        Task<IReadOnlyList<Product>> GetProductsAsync();
    }
}