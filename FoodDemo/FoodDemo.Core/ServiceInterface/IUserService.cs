using FoodDemo.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDemo.Core.ServiceInterface
{
    public interface IUserService
    {
        User SignIn(string username, string password);
        void SignUp(User user);
        User GetUser(string username);
        User Update(User user);
        void Delete(string username);
        int Commit();
    }
}
