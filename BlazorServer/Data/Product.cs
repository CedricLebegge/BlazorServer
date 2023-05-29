using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace BlazorServer.Data
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public Metal Metal { get; set; }
        public decimal Purity { get; set; }
        public decimal Weight { get; set; }
        public int Amount { get; set; }
        // Andere eigenschappen van het product...

        public async Task<bool> ValidateSerialNumber()
        {
            // Valideer het serienummer door een verzoek naar de WebAPI te sturen
            // en controleer of het al bestaat in de database.
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"https://example.com/api/stock/{Id}");

            return response.IsSuccessStatusCode;
        }
    }
}
