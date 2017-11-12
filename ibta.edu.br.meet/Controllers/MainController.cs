using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ibta.edu.br.meet.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult TelaPrincipal()
        {
            return View();
        }
    }
}