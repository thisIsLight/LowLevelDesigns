using System;
using System.Collections.Generic;
using System.Text;

namespace MoneySplitter.Users
{
    public class User : IUserFunctions
    {
        public string Id { get; set; }
        public Dictionary<User, double> Shares { get;}

        public User(string id)
        {
            Id = id;
            Shares = new Dictionary<User, double>();
        }

        public void Owes(User owesTo, double amount)
        {
            if(owesTo.Id == Id) {
                return;
            }
            owesTo.Owed(this, amount);
            if(Shares.ContainsKey(owesTo))
            {
                Shares[owesTo] -= amount;
            }
            else
            {
                Shares.TryAdd(owesTo, -amount);
            }
        }

        public void Owed(User owedBy, double amount)
        {
            if (Shares.ContainsKey(owedBy))
            {
                Shares[owedBy] += amount;
            }
            else
            {
                Shares.TryAdd(owedBy, +amount);
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach(var user in Shares)
            {
                var owesOrOwed = user.Value > 0 ? "gives to" : "gets from";
                sb.AppendLine($"User {user.Key.Id} {owesOrOwed} {this.Id} an amount of {Math.Abs(user.Value)}");
            }
            return sb.ToString();
        }
    }
}
