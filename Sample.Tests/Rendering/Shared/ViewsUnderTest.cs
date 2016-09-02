using System.Web.Mvc;
using HtmlAgilityPack;
using RazorGenerator.Testing;

namespace Sample.Tests.Rendering.Shared
{
    public class ViewsUnderTest
    {
        public HtmlDocument Document { get; private set; }
        public WebViewPage Instance { get; set; }
        public ViewsUnderTestViewEngine ViewEngine { get; private set; }

        public ViewsUnderTest()
        {
            ViewEngine = new ViewsUnderTestViewEngine();
        }

        public HtmlDocument RenderAsHtml()
        {
            Document = ((WebViewPage<object>) Instance).RenderAsHtml();
            return Document;
        }

        public HtmlDocument RenderAsHtml<TModel>(TModel model)
        {
            Document = ((WebViewPage<TModel>) Instance).RenderAsHtml(model);
            return Document;
        }

        /// <summary>
        /// Must be called after BeforeScenario Order 0
        /// </summary>
        /// <typeparam name="TPartial"></typeparam>
        /// <param name="path"></param>
        public void AddPartial<TPartial>(string path)
        {
            ViewEngine.AddPartial<TPartial>(path);
        }

        /// <summary>
        /// Must be called after BeforeScenario Order 0
        /// </summary>
        /// <typeparam name="TPartial"></typeparam>
        /// <param name="path"></param>
        public void Add<TView>(string path)
        {
            ViewEngine.Add<TView>(path);
        }
    }
}
