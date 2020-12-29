using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Muzej.Controllers
{
    public class OrdersController : Controller
    {
        //
        // GET: /Orders/
        public ActionResult Order()
        {
            return View();
        }
	}
}