using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Supershop.Helpers
{
    public interface IImageHelper
    {
        Task<string> UploadImageAsync(IFormFile imageFile, string folder);
    }
}
