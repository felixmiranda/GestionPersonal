using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private Legajo legajo = new Legajo();

        public ActionResult Index()
        {

            return View(legajo.Listar());
        }

        public ActionResult Crud(int id)
        {
            return View(legajo.Obtener(id));
        }

        public ActionResult Ver(int id)
        {
            return View(legajo.Obtener(id));
        }
    }
}