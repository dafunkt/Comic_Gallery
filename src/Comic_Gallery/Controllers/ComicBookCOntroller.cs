using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Comic_Gallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            {
                return Redirect("/");
                return new RedirectResult("/");
            }

            return Content("Hello frmo th comic book controller");
           

           
        }
    }
}