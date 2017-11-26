using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using ibta.edu.br.meet.Models;

namespace ibta.edu.br.meet.Controllers
{
    [Authorize]
    public class MainController : Controller
    {
        private UsuarioModel db = new UsuarioModel();
        
        // GET: Main
        public ActionResult TelaPrincipal()
        {
            //ViewBag.usuarios = db.AspNetUsers.ToList();
            //return View(db.AspNetUsers.Where(id => id.Email == "teste@teste.com").ToList());
            return View(db.Usuario.ToList());
        }

        [HttpPost]
        public ActionResult TelaPrincipal(string id, int status)
        {
            return View(db.Usuario.ToList());
        }

        public ActionResult newUsersChoice(string type, int idade)
        {
            //db.Usuario.Add();
            return TelaPrincipal();
        }
    }
}