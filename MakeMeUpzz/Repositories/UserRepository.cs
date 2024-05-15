using MakeMeUpzz.Factories;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repositories
{
    public class UserRepository
    {
        MakeMeUpzzDatabaseEntities db = DatabaseSingleton.GetInstance();

        public List<User> GetUsers()
        {
            return db.Users.ToList();
        }

        public int GenerateId()
        {
            var lastUserId = db.Users.OrderByDescending(u => u.UserID).Select(u => u.UserID).FirstOrDefault();
            return lastUserId + 1;
        }

        public void RegisterUser(int id, String username, String email, DateTime dob, String gender, String role, String password)
        {
            User user = new User();
            user.UserID = id;
            user.Username = username;
            user.UserEmail = email;
            user.UserDOB = dob;
            user.UserGender = gender;
            user.UserRole = role;
            user.UserPassword = password;
            db.Users.Add(user);
            db.SaveChanges();
        }
    }
}