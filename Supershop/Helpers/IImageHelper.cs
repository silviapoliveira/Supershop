using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Supershop.Helpers
{
    public interface IImageHelper
    {
        Task<string> UpdloadImageAsync(IFormFile imageFile, string folder);
    }
}
