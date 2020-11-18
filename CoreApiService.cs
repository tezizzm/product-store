using System;
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
            return await _client.GetStringAsync("/api/products");
        }

        public async Task CreateProduct(string product)
        {
            await _client.PostAsync("/api/products", new StringContent(product, Encoding.UTF8, "application/json"));
        }

        public async Task<string> GetProduct(int id)
        {
            return await _client.GetStringAsync($"/api/products/{id}");
        }

        public async Task DeleteProduct(int id)
        {
            await _client.DeleteAsync($"/api/products/{id}");
        }
    }
}
