using MoneySplitter.SplitMethodRegistrar;
using MoneySplitter.SplitMethodService;
using MoneySplitter.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoneySplitter.SplitHelper
{
    public class SplitHelper
    {
        public SplitMethodRegister SplitMethodRegister { get; set; }

        public SplitHelper(SplitMethodRegister splitMethodRegister)
        {
            SplitMethodRegister = splitMethodRegister;
        }

        public void AddExpanse(User payer, List<User> owers, double amount, Constants.SplitTypes splitType, List<double> shares = null)
        {
            try
            {
                SplitMethodRegister.splitMethods[splitType].Split(payer, owers, amount, shares);
            }
            catch (Exception ex)
            {
                throw new Exception("Split Method might not be defined", ex);
            }
        }
    }
}
