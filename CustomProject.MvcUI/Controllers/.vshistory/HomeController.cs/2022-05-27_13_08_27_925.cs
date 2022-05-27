using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomProject.MvcUI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            CategoriesORM orm = new CategoriesORM();
            List<Categories> kategoriler = orm.Select();
            return View(kategoriler);
        }
    }
}