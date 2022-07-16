using System;
using MyFinances.BL.Model;

namespace MyFinances.BL.Controller
{
    public class UserController
    {
        public User User { get; }

        public UserController(User user)
        {
            if (user is null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            User = user;
        }

        public bool Save()
        {
            return true;
        }
    }
}
