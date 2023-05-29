namespace BlazorServer.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }
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
