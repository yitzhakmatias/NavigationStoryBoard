using System.Threading.Tasks;
using App.Core.Models;

namespace App.Core.Services
{
    public interface IUserDataService
    {
        Task<User> SearchUser(string userName);

        Task<User> Login(string userName, string password);

        User GetActiveUser();
    }
}