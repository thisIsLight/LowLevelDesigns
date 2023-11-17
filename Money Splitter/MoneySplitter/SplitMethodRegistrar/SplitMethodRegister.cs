using MoneySplitter.SplitMethodService;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoneySplitter.SplitMethodRegistrar
{
    public class SplitMethodRegister
    {
        public Dictionary<Constants.SplitTypes, ISplitMethod> splitMethods;

        public SplitMethodRegister()
        {
            splitMethods = new Dictionary<Constants.SplitTypes, ISplitMethod>();
        }

        public void Register(ISplitMethod method, Constants.SplitTypes type)
        {
            splitMethods.Add(type,method);
        }
    }
}
