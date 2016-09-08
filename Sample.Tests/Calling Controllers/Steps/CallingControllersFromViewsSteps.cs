using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using ASP;
using Moq;
using NUnit.Framework;
using RazorGenerator.Testing;
using Sample.Mvc.Web.Controllers;
using Sample.Tests.MvcBindings;
using TechTalk.SpecFlow;

namespace Sample.Tests.Calling_Controllers.Steps
{
    [Binding]
    [Scope(Feature="Calling controllers from views")]
    public class CallingControllersFromViewsSteps
    {
        private readonly ViewsUnderTest viewsUnderTest;
        private readonly ControllersUnderTest controllersUnderTest;

        public CallingControllersFromViewsSteps(ViewsUnderTest viewsUnderTest, ControllersUnderTest controllersUnderTest)
        {
            this.viewsUnderTest = viewsUnderTest;
            this.controllersUnderTest = controllersUnderTest;
        }

        [Given(@"I have registered the controller with ControllersUnderTest")]
        public void GivenIHaveRegisteredTheControllerWithControllersUnderTest()
        {
            controllersUnderTest.Add("Simple", () => new SimpleController());
        }

        [Given(@"I have registered the partial with ViewsUnderTest")]
        public void GivenIHaveRegisteredThePartialWithViewsUnderTest()
        {
            viewsUnderTest.AddPartial<_Views_Shared_ControlledPartial_cshtml>("~/Views/Shared/ControlledPartial.cshtml");
        }

        [Given(@"I have a view that calls a controller")]
        public void GivenIHaveAViewThatCallsAController()
        {
            viewsUnderTest.Instance = new _Views_Simple_ControlledViewWithPartial_cshtml();;
        }

        [Then(@"the result should include HTML from the controller action")]
        public void ThenTheResultShouldIncludeHTMLFromTheControllerAction()
        {
            Assert.That(
                viewsUnderTest.Document.GetElementbyId("controlledPartialResult"),
                Is.Not.Null.And.Property("InnerHtml").EqualTo("4"),
                viewsUnderTest.Document.DocumentNode.OuterHtml
                );
        }
    }
}
