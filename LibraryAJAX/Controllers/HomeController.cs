using LibraryAJAX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryAJAX.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult GetByAuthor(string author)
        {
            Library2Entities db = new Library2Entities();
            List<book> list = db.books.Where(
                b => b.Author.Contains(author)
                ).ToList();

            return Json(list);
        }

        [HttpPost]
        public ActionResult GetByTitle(string title)
        {
            Library2Entities db = new Library2Entities();
            List<book> list = db.books.Where(
                b => b.Title.Contains(title)
                ).ToList();

            return Json(list);
        }

        [HttpPost]
        public ActionResult GetByYearPublished(int? year)
        {
            Library2Entities db = new Library2Entities();
            List<book> list = db.books.Where(
                b => b.YearPublished == year
                ).ToList();

            return Json(list);
        }

        [HttpPost]
        public ActionResult GetByPublisher(string publisher)
        {
            Library2Entities db = new Library2Entities();
            List<book> list = db.books.Where(
                b => b.Publisher.Contains(publisher)
                ).ToList();

            return Json(list);
        }
    }
}