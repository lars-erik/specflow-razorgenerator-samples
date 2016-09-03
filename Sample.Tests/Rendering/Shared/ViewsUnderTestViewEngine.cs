using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using RazorGenerator.Mvc;

namespace Sample.Tests.Rendering.Shared
{
    public class ViewsUnderTestViewEngine : IViewEngine
    {
        readonly Dictionary<string, Type> partialTypes = new Dictionary<string, Type>();
        readonly Dictionary<string, Type> viewTypes = new Dictionary<string, Type>();

        public ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
        {
            var key = partialTypes.Keys.FirstOrDefault(k => partialViewName.Contains(k) || k.Contains(partialViewName));
            if (key != null)
            {
                var view = new PrecompiledMvcView(partialViewName, partialTypes[key], false, new string[0]);
                return new ViewEngineResult(view, this);
            }
            return new ViewEngineResult(new string[0]);
        }

        public ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
        {
            var key = viewTypes.Keys.FirstOrDefault(k => viewName.Contains(k) || k.Contains(viewName));
            if (key != null)
            {
                var view = new PrecompiledMvcView(viewName, viewTypes[key], false, new string[0]);
                return new ViewEngineResult(view, this);
            }
            return new ViewEngineResult(new string[0]);
        }

        public void ReleaseView(ControllerContext controllerContext, IView view)
        {
        }

        public void AddPartial<TPartial>(string path)
        {
            partialTypes.Add(path, typeof(TPartial));
        }

        public void Add<TView>(string path)
        {
            viewTypes.Add(path, typeof(TView));
        }
    }
}
