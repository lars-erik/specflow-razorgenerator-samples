using ASP;
using HtmlAgilityPack;
using NUnit.Framework;
using RazorGenerator.Testing;
using Sample.Tests.MvcBindings;
using TechTalk.SpecFlow;

namespace Sample.Tests.Rendering.Steps
{
    [Binding]
    public class StandaloneViewsSteps
    {
        private readonly ViewsUnderTest viewsUnderTest;

        public StandaloneViewsSteps(ViewsUnderTest viewsUnderTest)
        {
            this.viewsUnderTest = viewsUnderTest;
        }

        [Given(@"I have an instance of a simple view")]
        public void GivenIHaveAnInstanceOfASimpleView()
        {
            viewsUnderTest.Instance = new _Views_Simple_SimpleView_cshtml();
        }

        [Then(@"the result should be a HTML document")]
        public void ThenTheResultShouldBeAHTMLDocument()
        {
            
            Assert.That(viewsUnderTest.Document.GetElementbyId("result"), Is.Not.Null.And.Property("InnerText").EqualTo("3"));
        }
    }
}
