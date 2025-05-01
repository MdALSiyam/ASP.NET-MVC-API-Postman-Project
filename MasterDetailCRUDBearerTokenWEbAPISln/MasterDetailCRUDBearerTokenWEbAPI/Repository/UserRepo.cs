using MasterDetailCRUDBearerTokenWEbAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MasterDetailCRUDBearerTokenWEbAPI.Repository
{
    public class UserRepo : IDisposable
    {
        private readonly AppDbContext db = new AppDbContext();
        [Authorize]
        public void Dispose()
        {
            db.Dispose();
        }
        public User ValidateUser(string userName, string password)
        {
            return db.Users.FirstOrDefault(u => u.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase) && u.Password == password);
        }
    }
}