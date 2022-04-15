// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using UserAttributes;

namespace requisicaoHttpCSharp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient { BaseAddress = new Uri("https://jsonplaceholder.typicode.com") };

            var response = await client.GetAsync("/users");
            var content = await response.Content.ReadAsStringAsync();

            var users = JsonConvert.DeserializeObject<User[]>(content);

            foreach (var item in users)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}