using OnionApp.WebUI.Dtos.ReservationDtos;

namespace OnionApp.WebUI.Services.ReservationServices
{
    public class ReservationService:IReservationService
    {
        private readonly HttpClient _client;

        public ReservationService(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("ApiClient");
        }

        public async Task<bool> CreateAsync(CreateReservationDto dto)
        {
            try
            {
                var response = await _client.PostAsJsonAsync("Reservations", dto);

                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }
    }
}
