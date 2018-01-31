using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Core.Models;
using App.Core.Repository;

namespace App.Core.Services
{
    public class UserDataService : IUserDataService
    {
        private readonly IUserRepository _userRepository;
        private User _activeUser;
        public UserDataService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> SearchUser(string userName)
        {
            return await _userRepository.SearchUser(userName);
        }

        public async Task<User> Login(string userName, string password)
        {
            _activeUser = await _userRepository.Login(userName, password);
            return _activeUser;
        }

        public User GetActiveUser()
        {
            return _activeUser;
        }
    }
}
