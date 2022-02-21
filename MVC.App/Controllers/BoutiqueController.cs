using MVC.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.App.Controllers
{
    public class BoutiqueController : Controller
    {
       
        public ActionResult AllBoutique()
        {
            var com = new Datacomponent();
            var model = com.GetAllBoutique();
            return View(model);
        }
    }
}