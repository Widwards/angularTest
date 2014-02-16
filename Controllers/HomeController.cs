using AngularTestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularTestApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Books()
        {
            var allBook = new Catalog();
            return Json(allBook, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetBook(int id)
        {
            var allbooks = new Catalog();
            var book = allbooks.Books.FirstOrDefault(x => x.Id == id);

            return View(book);
        }

    }
}