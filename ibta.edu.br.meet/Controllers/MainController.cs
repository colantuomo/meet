using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;


namespace ibta.edu.br.meet.Controllers
{
    [Authorize]
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult TelaPrincipal()
        {
            var teste = User.Identity.GetUserId();
            return View();
        }
    }
}