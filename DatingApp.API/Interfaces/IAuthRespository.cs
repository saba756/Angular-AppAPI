using DatingApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Data
{
   public interface IAuthRespository
    {
        Task<User> Resgister(User user, string password);
        Task<User> Login(string username , string password);
        Task<bool> UserExist (string username);
    }
}
