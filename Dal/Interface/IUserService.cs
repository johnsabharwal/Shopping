using Dal.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Interface
{
    public interface IUserService
    {
        UserInfo GetUser(string emailId,string password);
        int RegisterUser(UserInfo userInfo);
    }
}
