using MoneySplitter.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoneySplitter.SplitMethodService
{
    public class ExactSplitMethod : ISplitMethod
    {
        public void Split(User payer, List<User> owers, double amount, List<double> shares = null)
        {
            if (shares == null || shares.Count != owers.Count)
            {
                throw new ArgumentNullException("Shares not Provided for Exact Split");
            }
            else
            {
                var indexOfShare = 0;
                foreach (var user in owers)
                {
                    user.Owes(payer, shares[indexOfShare]);
                    indexOfShare++;
                }
            }
        }
    }
}
