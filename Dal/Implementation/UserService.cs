using Dal.DTO;
using Dal.Entities;
using Dal.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dal.Implementation
{
    public class UserService : IUserService
    {
        DBContext dBContext;
        public UserService(DBContext db)
        {
            dBContext = db;
        }
        public UserInfo GetUser(string email, string password)
        {
            var user = dBContext.Users.Where(x => x.EmailId == email.ToLower() && x.Password == password).FirstOrDefault();
            if (user != null)
            {
                user.LastLogin = DateTime.Now;
                dBContext.SaveChanges();
                return new UserInfo()
                {
                    Id = user.Id,
                    Name = user.Name,
                    LastName = user.LastName,
                    Address = user.Address,
                    DateCreated = user.DateCreated,
                    LastLogin = user.LastLogin,
                    MobileNo = user.MobileNo,
                    EmailId = user.EmailId
                };
            }
            return null;
        }

        public int RegisterUser(UserInfo userInfo)
        {
            if (!dBContext.Users.Where(x => x.EmailId == userInfo.EmailId.ToLower() || x.MobileNo == userInfo.MobileNo).Any())
            {
                User user = new Entities.User()
                {
                    EmailId = userInfo.EmailId,
                    Name = userInfo.Name,
                    LastName = userInfo.LastName,
                    MobileNo = userInfo.MobileNo,
                    DateCreated = DateTime.Now,
                    Password = userInfo.Password,
                    Address = userInfo.Address
                };
                dBContext.Users.Add(user);
                dBContext.SaveChanges();
                return user.Id;
            }
            return 0;
        }
    }
}
