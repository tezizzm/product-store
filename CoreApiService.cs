using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace bootcamp_store
{
    public class CoreApiService : ICoreApiService
    {
        private HttpClient _client { get; }

        public CoreApiService(HttpClient client)
        {
            _client = client;
        }

        public async Task<string> GetProducts()
        {
            return await _client.GetStringAsync("");
        }

        public async Task CreateProduct(string product)
        {
            await _client.PostAsync("", new StringContent("product", Encoding.UTF8, "application/json"));
        }

        public async Task<string> GetProduct(string id)
        {
            return await _client.GetStringAsync($"/{id}");
        }

        public async Task DeleteProduct(string id)
        {
            await _client.DeleteAsync($"/{id}");
        }
    }
}
