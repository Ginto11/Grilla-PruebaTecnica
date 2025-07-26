using Grilla.models;
using System.Text.Json;

namespace Grilla.Services
{
    public class DataService
    {
        // INYECCIÓN DE DEPENDENCIAS PARA LA CONFIGURACIÓN Y EL CLIENTE HTTP
        private readonly IConfiguration configuration;
        private readonly HttpClient httpClient;

        public DataService(IConfiguration configuration, HttpClient httpClient)
        {
            this.configuration = configuration;
            this.httpClient = httpClient;
        }

        public async Task<List<Item>?> GetDataAsync()
        {
            // OBTENER EL TOKEN DESDE LA CONFIGURACIÓN
            var token = configuration["Jwt:Token"];

            // CONFIGURAR EL CLIENTE HTTP CON EL TOKEN
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            // SOLICITUD GET
            var response = await httpClient.GetAsync(configuration["Api:Url"]); // Cambia la URL por la real

            // LANZA LA EXCEPTION SI LA RESPUESTA NO ES EXITOSA
            response.EnsureSuccessStatusCode();

            // LEER EL CONTENIDO DE LA RESPUESTA
            var content = await response.Content.ReadAsStringAsync();

            // DESERIALIZAR EL CONTENIDO A UNA LISTA DE ITEMS
            var items = System.Text.Json.JsonSerializer.Deserialize<List<Item>>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return items;
        }
    }
}
