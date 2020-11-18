using System.Threading.Tasks;

namespace bootcamp_store
{
    public interface ICoreApiService
    {
        Task<string> GetProducts();
        Task CreateProduct(string product);
        Task<string> GetProduct(int id);
        Task DeleteProduct(int id);
    }
}