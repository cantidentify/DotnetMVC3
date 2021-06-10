using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotnetMVC3.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            throw new NotImplementedException();
        }
        public ActionResult Details(int Id)
        {
            return View("Details");
        }
    }
}