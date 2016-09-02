using System.IO;
using System.Web;
using System.Web.Mvc;
using RazorGenerator.Testing;
using TechTalk.SpecFlow;

namespace Sample.Tests.Rendering.Shared
{
    [Binding]
    public class ViewsUnderTestSteps
    {
        private readonly ViewsUnderTest viewsUnderTest;

        public ViewsUnderTestSteps(ViewsUnderTest viewsUnderTest)
        {
            this.viewsUnderTest = viewsUnderTest;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            HttpContext.Current = new HttpContext(new HttpRequest("", "http://localhost", ""), new HttpResponse(new StringWriter()));

            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(viewsUnderTest.ViewEngine);
            ViewEngines.Engines.Add(WebViewPageExtensions.ViewEngine);
        }

        [When(@"I use the RenderAsHtml extension")]
        public void WhenIUseTheRenderAsHtmlExtension()
        {
            viewsUnderTest.RenderAsHtml();
        }

    }
}
