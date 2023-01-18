using Microsoft.AspNetCore.Mvc;
using E_Shopping_App.Entities;
namespace E_Shopping_App.Repositories
{

    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        //Task<IEnumerable<Product>> GetProducts(CancellationToken cancellationToken);

        Task<IEnumerable<Product>> GetProductByName(string name);
        Task<IEnumerable<Product>> GetProductByType(string type);
        Task<IEnumerable<Product>> GetProductBySize(string size);

        Task CreateProduct(Product product);
        Task<bool> UpdateProduct(Product product);
        Task<bool> DeleteProduct(string id);

    }
}