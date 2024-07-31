using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Supershop.Helpers
{
    public interface IBlobHelper
    {
        Task<Guid> UploadBlobAsync(IFormFile file, string containerName); // através de ficheiro

        Task<Guid> UploadBlobAsync(byte[] file, string containerName); // através de um array de bytes (para o mobile)

        Task<Guid> UploadBlobAsync(string image, string containerName); // através de uma string (um url)
    }
}