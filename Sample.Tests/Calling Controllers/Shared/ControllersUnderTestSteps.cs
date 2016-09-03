using System.Web.Mvc;
using TechTalk.SpecFlow;

namespace Sample.Tests.Calling_Controllers.Shared
{
    [Binding]
    public class ControllersUnderTestSteps
    {
        private readonly ControllersUnderTest controllersUnderTest;

        public ControllersUnderTestSteps(ControllersUnderTest controllersUnderTest)
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