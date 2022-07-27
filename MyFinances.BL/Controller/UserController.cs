using System;
using MyFinances.BL.Model;

namespace MyFinances.BL.Controller
{
    public class UserController
    {
        public User User { get; }

        public UserController(User user)
        {
            User = user ?? throw new ArgumentNullException(nameof(user));
        }

        public bool Save()
        {
            return true;
        }
    }
}
