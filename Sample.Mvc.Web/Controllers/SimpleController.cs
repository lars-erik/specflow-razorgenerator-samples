using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sample.Mvc.Web.Models;

namespace Sample.Mvc.Web.Controllers
{
    public class SimpleController : Controller
    {
        // GET: Simple
        public ActionResult ControlledWithPartial()
        {
            return View("ControlledViewWithPartial");
        }

        public ActionResult ControlledPartial()
        {
            var model = new ControlledPartialModel
            {
                Value = 3 + 1
            };
            return PartialView("ControlledPartial", model);
        }
    }
}