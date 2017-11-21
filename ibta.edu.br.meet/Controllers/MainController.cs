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

        public ibta.edu.br.meet.Models.UsuariosModels db = new ibta.edu.br.meet.Models.UsuariosModels();
        
        // GET: Main
        public ActionResult TelaPrincipal()
        {
            return View(db.AspNetUsers.ToList());
        }
    }
}