using OnionApp.WebUI.Base;
using OnionApp.WebUI.Dtos.ContactDtos;

namespace OnionApp.WebUI.Services.ContactServices
{
    public class ContactService:IContactService
    {
        private readonly HttpClient _client;

        public ContactService(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("ApiClient");
        }

        public async Task<BaseResult<object>> CreateAsync(CreateContactDto create)
        {
            var response = await _client.PostAsJsonAsync("contacts", create);

            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();

            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> DeleteAsync(int id)
        {
            var response = await _client.DeleteAsync($"contacts/{id}");
            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();
            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<List<ResultContactDto>>> GetAllAsync()
        {
            var response = await _client.GetAsync("contacts");
            var result = await response.Content.ReadFromJsonAsync<BaseResult<List<ResultContactDto>>>();
            return result ?? new BaseResult<List<ResultContactDto>>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<UpdateContactDto>> GetByIdAsync(int id)
        {
            var response = await _client.GetAsync($"contacts/{id}");
            var result = await response.Content.ReadFromJsonAsync<BaseResult<UpdateContactDto>>();
            return result ?? new BaseResult<UpdateContactDto>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }

        public async Task<BaseResult<object>> UpdateAsync(UpdateContactDto update)
        {
            var response = await _client.PutAsJsonAsync("contacts", update);
            var result = await response.Content.ReadFromJsonAsync<BaseResult<object>>();
            return result ?? new BaseResult<object>
            {
                Errors = new() { new Error { ErrorMessage = "Deserialize hatası" } }
            };
        }
    }
}
