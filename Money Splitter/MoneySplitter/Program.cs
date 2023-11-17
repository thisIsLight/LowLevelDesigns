using MoneySplitter.SplitMethodRegistrar;
using MoneySplitter.SplitMethodService;
using MoneySplitter.Users;
using System;
using System.Collections.Generic;

namespace MoneySplitter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating the system first
            var registrar = new SplitMethodRegister();
            registrar.Register(new PercentageSplitMethod(), Constants.SplitTypes.PERCENTAGE);
            registrar.Register(new ExactSplitMethod(), Constants.SplitTypes.EXACT);
            registrar.Register(new EqualSplitMethod(), Constants.SplitTypes.EQUAL);

            var splitMachine = new SplitHelper.SplitHelper(registrar);

            var u1 = new User("U1");
            var u2 = new User("U2");
            var u3 = new User("U3");
            var u4 = new User("U4");
            //System is ready now.
            //Time to add some expenses

            splitMachine.AddExpanse(u1, new List<User>() { u1, u2, u3 }, 100, Constants.SplitTypes.PERCENTAGE,new List<double>(){ 40,30,30});
            splitMachine.AddExpanse(u1, new List<User>() { u1, u2, u3,u4 }, 100, Constants.SplitTypes.EQUAL);
            splitMachine.AddExpanse(u1, new List<User>() { u2 }, 50, Constants.SplitTypes.EXACT,new List<double>(){50});
            splitMachine.AddExpanse(u2, new List<User>() { u1, u2 }, 100, Constants.SplitTypes.EXACT,new List<double>(){ 40,60});
            splitMachine.AddExpanse(u2, new List<User>() { u1 }, 200, Constants.SplitTypes.EXACT,new List<double>(){ 200});


            Console.WriteLine(u1);
            Console.WriteLine(u2);
            Console.WriteLine(u3);
            Console.WriteLine(u4);

        }
    }
}
