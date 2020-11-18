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
            return await _client.GetStringAsync("");
        }

        public async Task CreateProduct(string product)
        {
            await _client.PostAsync("", new StringContent(product, Encoding.UTF8, "application/json"));
        }

        public async Task<string> GetProduct(int id)
        {
            Console.WriteLine(_client.BaseAddress + $"/{id}");
            return await _client.GetStringAsync($"/{id}");
        }

        public async Task DeleteProduct(int id)
        {
            Console.WriteLine(_client.BaseAddress + $"/{id}");
            await _client.DeleteAsync($"/{id}");
        }
    }
}
