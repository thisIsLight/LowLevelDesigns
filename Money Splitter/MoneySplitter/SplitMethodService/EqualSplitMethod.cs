using MoneySplitter.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoneySplitter.SplitMethodService
{
    public class EqualSplitMethod : ISplitMethod
    {
        public void Split(User payer, List<User> owers, double amount, List<double> shares = null)
        {
            var eachShare = amount / owers.Count;
            foreach (var user in owers)
            {
                user.Owes(payer, eachShare);
            }
        }
    }
}
