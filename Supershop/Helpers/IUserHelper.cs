using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Supershop.Data.Entities;
using Supershop.Models;

namespace Supershop.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();
    }
}
