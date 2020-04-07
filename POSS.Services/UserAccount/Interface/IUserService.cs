using POSS.Models.UserAccount;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSS.Services.UserAccount
{
    public interface IUserService
    {
        UserModel Authenticate(string username, string password);
        IEnumerable<UserModel> GetAll();
        UserModel GetById(int id);
    }
}
