using System.ComponentModel.DataAnnotations;

namespace BlazorServer.Data
{
    public class Product
    {
        [Key]
        public int SerialNumber { get; set; }
        public int Amount { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        // Andere eigenschappen van het product...

        public async Task<bool> ValidateSerialNumber()
        {
            // Valideer het serienummer door een verzoek naar de WebAPI te sturen
            // en controleer of het al bestaat in de database.
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"https://example.com/api/stock/{SerialNumber}");

            return response.IsSuccessStatusCode;
        }
    }
}
