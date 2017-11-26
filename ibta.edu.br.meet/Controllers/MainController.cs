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
        private UsuarioModel dbUsuario = new UsuarioModel();
        private MatchModel dbMatch = new MatchModel();
        private Match newMatch = new Match();
        private Guid g;

        // GET: Main
        public ActionResult TelaPrincipal()
        {
            //ViewBag.usuarios = db.AspNetUsers.ToList();
            //return View(db.AspNetUsers.Where(id => id.Email == "teste@teste.com").ToList());
            return View(dbUsuario.Usuario.ToList());
        }

        public void matchAdd(string id, bool status)
        {
            //§
            g = Guid.NewGuid();
            newMatch.IdMatch = g.ToString();
            newMatch.IdUsuario = User.Identity.GetUserId();
            newMatch.IdUsuarioCurtido = id;
            newMatch.Status = status;

            dbMatch.Match.Add(newMatch);
            dbMatch.SaveChanges();

            RedirectToAction("TelaPrincipal");
        }

        public ActionResult newUsersChoice(string type, int idade)
        {
            //db.Usuario.Add();
            return TelaPrincipal();
        }
    }
}