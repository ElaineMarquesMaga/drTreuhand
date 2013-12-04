using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrTreuhand.Controllers
{
    public class DRTreuhandController : Controller
    {
        //
        // GET: /DRTreuhand/ http://forums.asp.net/t/1792628.aspx for xml example

        public ActionResult Referenzen()
        {
            ViewBag.Title = "Referenzen";          
            return View();
        }

        public ActionResult Unternehmer()
             
        {
            
            ViewBag.Title = "Unternehmer";
            return View();

        }
         public ActionResult Leistungen()

        {
            ViewBag.Title = "Leistungen";
            return View();

        }
         public ActionResult Formulare()
        {
            ViewBag.Title = "Formulare";
             return View();

        }
         public ActionResult Kontakt()
        { 

            ViewBag.Title = "Kontakt" ;
             return View();

        }

         public ActionResult Index()
         {
             ViewBag.Title = "Index";
             return View();

         }

    }
}



