using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using RazorGenerator.Mvc;

namespace Sample.Tests.Rendering.Shared
{
    public class ViewsUnderTestViewEngine : IViewEngine
    {
        readonly Dictionary<string, Type> partials = new Dictionary<string, Type>();
        readonly Dictionary<string, Type> views = new Dictionary<string, Type>();

        public ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
        {
            var key = partials.Keys.FirstOrDefault(k => partialViewName.Contains(k) || k.Contains(partialViewName));
            if (key != null)
            {
                var view = new PrecompiledMvcView(partialViewName, partials[key], false, new string[0]);
                return new ViewEngineResult(view, this);
            }
            return null;
        }

        public ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
        {
            var key = views.Keys.FirstOrDefault(k => viewName.Contains(k) || k.Contains(viewName));
            if (key != null)
            {
                var view = new PrecompiledMvcView(viewName, views[key], false, new string[0]);
                return new ViewEngineResult(view, this);
            }
            return null;
        }

        public void ReleaseView(ControllerContext controllerContext, IView view)
        {
        }

        public void AddPartial<TPartial>(string path)
        {
            partials.Add(path, typeof(TPartial));
        }

        public void Add<TView>(string path)
        {
            views.Add(path, typeof(TView));
        }
    }
}
