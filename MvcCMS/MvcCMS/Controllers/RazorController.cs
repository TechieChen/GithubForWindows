using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCMS.Models;

namespace MvcCMS.Controllers
{
    public class RazorController : Controller
    {
        //
        // GET: /Razor/

        public ActionResult Index()
        {
            var posts = new MvcContext().Posts;
            //ViewData["Posts"] = posts;
            return View("Index",posts);
        }

    }
}
