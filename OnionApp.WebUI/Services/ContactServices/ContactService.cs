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

        public Task<BaseResult<object>> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResult<List<ResultContactDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BaseResult<UpdateContactDto>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResult<object>> UpdateAsync(UpdateContactDto update)
        {
            throw new NotImplementedException();
        }
    }
}
