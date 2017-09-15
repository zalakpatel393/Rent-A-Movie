using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using RAM.Models;
using RAM.ViewModels;

namespace RAM.Controllers
{
    public class RentalsController : Controller
    {
        public ActionResult New()
        {
            return View();
        }

        public ViewResult List()
        {
           
                return View("List");

           
        }

    }
}