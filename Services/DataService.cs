using Grilla.models;
using System.Text.Json;

namespace Grilla.Services
{
    public class DataService
    {
        private readonly IConfiguration configuration;
        private readonly HttpClient httpClient;

        public DataService(IConfiguration configuration, HttpClient httpClient)
        {
            this.configuration = configuration;
            this.httpClient = httpClient;
        }

        public async Task<List<Item>?> GetDataAsync()
        {
            // Obtener el token desde configuración
            var token = configuration["Jwt:Token"];

            // Configura HttpClient con el token Bearer
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            // Hacer la solicitud GET
            var response = await httpClient.GetAsync(configuration["Api:Url"]); // Cambia la URL por la real

            // Lanzar excepción si falla
            response.EnsureSuccessStatusCode();

            // Leer y deserializar los datos
            var content = await response.Content.ReadAsStringAsync();
            Console.Write(content);
            var items = System.Text.Json.JsonSerializer.Deserialize<List<Item>>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return items;
        }
    }
}
