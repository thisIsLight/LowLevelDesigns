using MoneySplitter.Users;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace MoneySplitter.SplitMethodService
{
    public interface ISplitMethod
    {
        void Split(User payer, List<User> owers, double amount, List<double> shares = null);
    }
}
