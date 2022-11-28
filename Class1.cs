using System.Threading.Tasks;
using Refit;

namespace Exemplorefit
{
    public interface IcepApiService
    {
        [Get("/ws{cep}/json")]
        Task<CepResponse> GetAddressAsync(string cep);
    }
}
