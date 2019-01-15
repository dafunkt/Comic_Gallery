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

            ViewBag.SeriesTitle = "The Amazing Spider-man";
            ViewBag.IssueNumber = 400;
            ViewBag.Description = "<p> FInal issue!</p>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto",
                "Inks: Victor",
                "Colors: Edgar Delgado",
                "Letters: Chris Elio"
            };
            return View();
           

           
        }
    }
}