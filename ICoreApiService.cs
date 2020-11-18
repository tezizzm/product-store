using System.Threading.Tasks;

namespace bootcamp_store
{
    public interface ICoreApiService
    {
        Task<string> GetProducts();
        Task CreateProduct(string product);
        Task<string> GetProduct(string id);
        Task DeleteProduct(string id);
    }
}