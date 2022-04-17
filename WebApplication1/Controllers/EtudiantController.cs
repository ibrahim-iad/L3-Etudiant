using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EtudiantController : Controller
    {
        // GET: Etudiant
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return View();
        }

        public ActionResult List2()
        {
            Etudiant et = new Etudiant();// { id = 1, Nom = "Gouled", Adresse = "Balbala", Telephone="77112233" };
            et.id = 1;
            et.Nom = "Gouled";
            et.Adresse = "Balbala";
            et.Telephone = "77112233";
            return View(et);
        }

        public ActionResult List3()
        {
            Etudiant et1 = new Etudiant() { id = 1, Nom = "Gouled", Adresse = "Balbala", Telephone="77112233" };
            Etudiant et2 = new Etudiant() { id = 2, Nom = "Amina", Adresse = "Barwaqo", Telephone = "7747845" };
            Etudiant et3 = new Etudiant() { id = 3, Nom = "Hassan", Adresse = "Q5", Telephone = "77145236" };
            List<Etudiant> etudiants = new List<Etudiant>();
            etudiants.Add(et1); etudiants.Add(et2); etudiants.Add(et3);
            return View(etudiants);
        }
    }
}