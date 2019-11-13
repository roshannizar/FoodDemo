using FoodDemo.Core.ServiceInterface;
using FoodDemo.Data.Context;
using FoodDemo.Data.Entity;
using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace FoodDemo.Core.Services
{
    public class UserService : IUserService
    {
        private readonly FoodDbContext db;

        public UserService(FoodDbContext db)
        {
            this.db = db;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public void Delete(string username)
        {
            var user = GetUser(username);

            if(user != null)
            {
                db.Users.Remove(user);
            }
        }

        public User GetUser(string username)
        {
            var query = from u in db.Users
                        where u.Username.StartsWith(username) || string.IsNullOrEmpty(username)
                        select u;

            return (User)query;
        }

        public User SignIn(string username, string password)
        {
            var user = this.GetUser(username);

            if(user.Username == username && user.Password == password)
            {
                return user;
            }

            return user;
        }

        public void SignUp(User user)
        {
            if(user != null)
            {
                db.Users.Add(user);
            }
            else
            {
                Console.WriteLine("User is empty");
            }
        }

        public User Update(User user)
        {
            var entity = db.Users.Attach(user);
            entity.State = EntityState.Modified;
            return user;
        }
    }
}
