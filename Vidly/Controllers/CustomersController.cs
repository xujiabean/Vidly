using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Dump(int? id)
        {
            if(id.HasValue)
                return Content(String.Format("Dump Data with ID: {0}", id));
            else
                return Content(String.Format("Dump Empty Data!"));
        }
    }
}