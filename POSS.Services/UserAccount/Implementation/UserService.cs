
using Helpers;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using POSS.DataAccess.Context;
using POSS.Models.UserAccount;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace POSS.Services.UserAccount.Implementation
{
    public class UserService : IUserService
    {
        // users hardcoded for simplicity, store in a db with hashed passwords in production applications

        private readonly POSSDbContext dbContext;
        private readonly AppSettings _appSettings;
        private List<UserModel> users;

        public UserService(IOptions<AppSettings> appSettings, POSSDbContext _dbContext)
        {
            _appSettings = appSettings.Value;
            dbContext = _dbContext;
            users = UsersList();
        }

        public List<UserModel> UsersList()
        {
            using(dbContext)
            {
                return dbContext.Users.Select(x => new UserModel
                {
                    Id = x.Id,
                    LastName = x.LastName,
                    FirstName = x.FirstName,
                    Username = x.Username,
                    Password = x.Password,
                    Role = x.Role,
                    Token = x.Token
                }).ToList();
            }
        }
        public UserModel Authenticate(string username, string password)
        {
            var user = users.SingleOrDefault(x => x.Username == username && x.Password == password); 
              
            // return null if user not found
            if (user == null)
                return null;

            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString()),
                    new Claim(ClaimTypes.Role, user.Role)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);

            // remove password before returning
            user.Password = null;

            return user;
        }

        public IEnumerable<UserModel> GetAll()
        {
            // return users without passwords
            using(dbContext)
            {
                return users.Select(  x => {
                    x.Password = null;
                    return x;
                });
            }   
        }

        public UserModel GetById(int id)
        {
            var user = users.FirstOrDefault(x => x.Id == id);

            // return user without password
            if (user != null)
                user.Password = null;

            return user;
        }

    }
}
