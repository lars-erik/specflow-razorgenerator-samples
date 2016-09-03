using System;
using System.Web.Mvc;

namespace Sample.Tests.Calling_Controllers.Shared
{
    public class ControllersUnderTest
    {
        readonly ControllersUnderTestFactory testFactory = new ControllersUnderTestFactory();

        public ControllersUnderTestFactory Factory
        {
            get { return testFactory; }
        }

        public void Add(string name, Func<Controller> factory)
        {
            testFactory.Add(name, factory);
        }
    }
}