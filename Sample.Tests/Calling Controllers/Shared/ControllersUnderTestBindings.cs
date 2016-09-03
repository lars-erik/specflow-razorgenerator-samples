using System.Web.Mvc;
using TechTalk.SpecFlow;

namespace Sample.Tests.Calling_Controllers.Shared
{
    [Binding]
    public class ControllersUnderTestBindings
    {
        private readonly ControllersUnderTest controllersUnderTest;

        public ControllersUnderTestBindings(ControllersUnderTest controllersUnderTest)
        {
            this.controllersUnderTest = controllersUnderTest;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            ControllerBuilder.Current.SetControllerFactory(controllersUnderTest.Factory);
        }
    }
}