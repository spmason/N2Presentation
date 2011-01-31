﻿#if DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace N2Presentation.Areas.Tests.Controllers
{
	/// <summary>
	/// This is an example of a controller not connected to a content item.
	/// To use non-content controllers make sure to register a route for it.
	/// </summary>
    public class StaticController : Controller
    {
        //
        // GET:	/Tests/Static/	

        public ActionResult Index()
        {
            return View();
        }

    }
}
#endif