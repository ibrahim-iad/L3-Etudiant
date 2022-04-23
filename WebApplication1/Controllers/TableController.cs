using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class TableController : Controller
    {
        // GET: Table
        public ActionResult Index(int id)
        {
            return View(id);
        }

        public ActionResult Index2(int id)
        {
            List<string> lignes = new List<string>();
            for (int i=1; i<=10; i++)
            {
                StringBuilder s = new StringBuilder();
                s.AppendFormat("{0} X {1} = {2}", id, i, (id * i));
                lignes.Add(s.ToString());
            }

            return View("Index2", lignes);
        }

        public ActionResult Index3()
        {
            int id = Convert.ToInt32(Request["id"]);
            List<string> lignes = new List<string>();
            for (int i = 1; i <= 10; i++)
            {
                StringBuilder s = new StringBuilder();
                s.AppendFormat("{0} X {1} = {2}", id, i, (id * i));
                lignes.Add(s.ToString());
            }

            return View("Index2", lignes);
        }

    }
}