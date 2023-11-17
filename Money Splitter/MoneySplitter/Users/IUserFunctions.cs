using System;
using System.Collections.Generic;
using System.Text;

namespace MoneySplitter.Users
{
    public interface IUserFunctions
    {
        public void Owes(User owesTo, double amount);
        public void Owed(User owedBy, double amount);
    }
}
