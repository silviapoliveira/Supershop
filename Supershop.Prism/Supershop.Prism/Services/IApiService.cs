using Supershop.Prism.Models;
using System.Threading.Tasks;

namespace Supershop.Prism.Services
{
    public interface IApiService
    {
        Task<Response> GetListAsync<T>(string urlBase, string servicePrefix, string controller);
    }
}
