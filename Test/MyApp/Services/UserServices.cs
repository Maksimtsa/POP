using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Models;

namespace MyApp.Services
{
    public class UserServices
    {
        private readonly List<User> _users = new List<User>();

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public User GetUserById(int id)
        {
            return _users.FirstOrDefault(u => u.Id == id);
        }

        public List<User> GetAllUsers()
        {
            return _users;
        }

        public bool RemoveUsers(int id)
        {
            var user = GetUserById(id);
            if(user != null)
            {
                _users.Remove(user);
                return true;
            }

            return false;
        }
    }
}
