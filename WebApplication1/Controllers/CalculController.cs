using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CalculController : Controller
    {
        // GET: Calcul
        public ActionResult Index(int id1, int id2)
        {
            CalculResultat model = new CalculResultat();
            model.nombre1 = id1;
            model.nombre2 = id2;
            model.somme = id1 + id2;
            model.difference = id1 - id2;
            model.produit = id1 * id2;
            model.division = Convert.ToSingle(id1) / id2;
            return View(model);
        }

        public ActionResult New()
        {
            CalculResultat model = new CalculResultat();
            return View(model);
        }

        [HttpPost]
        public ActionResult New(CalculResultat model)
        {
            model.somme = model.nombre1 + model.nombre2;
            model.difference = model.nombre1 - model.nombre2;
            model.produit = model.nombre1 * model.nombre2;
            model.division = Convert.ToSingle(model.nombre1) / model.nombre2;
            return View("Index", model);            
        }

        public ActionResult New2()
        {
            CalculResultat model = new CalculResultat();
            return View(model);
        }

        [HttpPost]
        public ActionResult New2(int nombre1, int nombre2)
        {
            CalculResultat model = new CalculResultat();
            model.nombre1 = nombre1;
            model.nombre2 = nombre2;
            model.somme = nombre1 + nombre2;
            model.difference = nombre1 - nombre2;
            model.produit = nombre1 * nombre2;
            model.division = Convert.ToSingle(nombre1) / nombre2;
            return View("Index", model);
        }
    }
}