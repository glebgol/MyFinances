using System;

namespace MyFinances.BL.Model
{
    public class User
    {
        public int Id { get; }
        public string Name { get; private set; }
        public string Email { get; private set; }

        protected List<Expence> expences;
        protected List<Income> income;

        public User(string name, string email)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentNullException(nameof(email));
            }

            Name = name;
            Email = email;
            expences = new List<Expence>();
            income = new List<Income>();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
