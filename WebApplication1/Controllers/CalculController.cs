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
    }
}