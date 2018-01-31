using System.Threading.Tasks;
using App.Core.Models;

namespace App.Core.Repository
{
    public interface IUserRepository
    {
        Task<User> SearchUser(string userName);

        Task<User> Login(string userName, string password);
    }
}