using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class RectangleController : Controller
    {
        // GET: Rectangle
        public ActionResult Index()
        {
            RectangleModel model = new RectangleModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Calcul(RectangleModel model)
        {
            model.Perimetre = 2 * (model.Longueur + model.Largeur);
            model.Surface = model.Longueur * model.Largeur;
            return View(model);
        }
    }
}