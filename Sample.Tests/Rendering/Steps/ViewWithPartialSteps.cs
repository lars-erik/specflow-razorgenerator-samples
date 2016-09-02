using ASP;
using NUnit.Framework;
using Sample.Tests.Rendering.Shared;
using TechTalk.SpecFlow;

namespace Sample.Tests.Rendering.Steps
{
    [Binding]
    public class ViewWithPartialSteps
    {
        private readonly ViewsUnderTest viewsUnderTest;

        public ViewWithPartialSteps(ViewsUnderTest viewsUnderTest)
        {
            this.viewsUnderTest = viewsUnderTest;
        }

        [BeforeScenario(Order = 1)]
        public void BeforeScenario()
        {
            viewsUnderTest.AddPartial<_Views_Partials_SimplePartial_cshtml>("~/Views/Partials/SimplePartial.cshtml");
        }

        [Given(@"I have an instance of a view with a partial")]
        public void GivenIHaveAnInstanceOfAViewWithAPartial()
        {
            viewsUnderTest.Instance = new _Views_SimpleViewWithPartial_cshtml();
        }

        [Then(@"the result should be a HtmlDocument containing HTML from the partial")]
        public void ThenTheResultShouldBeAHtmlDocumentContainingHTMLFromThePartial()
        {
            Assert.That(
                viewsUnderTest.Document.GetElementbyId("partialResult"), 
                Is.Not.Null.And.Property("InnerText").EqualTo("4"), 
                viewsUnderTest.Document.DocumentNode.OuterHtml
            );
        }
    }
}
