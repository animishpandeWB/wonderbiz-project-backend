using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial_Project.Models;

namespace Tutorial_Project.Services
{
    public static class UserService
    {
        static List<User> Users { get; }
        static int nextId = 3;
        static UserService()
        {
            Users = new List<User>
            {
                new User { Id = 1, Username = "Test1", Email = "test1@123.com", password = "123"},
                new User { Id = 2, Username = "Test2", Email = "test2@123.com", password = "456"},
            };
        }

        public static List<User> GetAllUsers()
        {
            return Users;
        }

        public static User? GetUser(int id)
        {
            return Users.FirstOrDefault(u => u.Id == id);
        }

        public static void AddUser(User user)
        {
            user.Id = nextId++;
            Users.Add(user);
        }

        public static void DeleteUser(int id)
        {
            var user = GetUser(id);
            if (user is null)
            {
                return;
            }
            Users.Remove(user);
        }

        public static void UpdateUser(User user)
        {
            var index = Users.FindIndex(u => u.Id == user.Id);
            if (index == -1)
            {
                return;
            }

            Users[index] = user;
        }
    }
}