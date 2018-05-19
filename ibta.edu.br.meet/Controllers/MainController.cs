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
        private vw_TelaPrincipalModel dbTelaPrincipal = new vw_TelaPrincipalModel();
        private vw_MatchesModel dbMatches = new vw_MatchesModel();
        private UsuarioModel dbUsuario = new UsuarioModel();
                
        // GET: Main
        public ActionResult TelaPrincipal()
        {
            //ViewBag.usuarios = db.AspNetUsers.ToList();
            //return View(dbUsuario.Usuario.ToList());
            IdUsuario = User.Identity.GetUserId();
            return View(dbTelaPrincipal.vw_TelaPrincipal.Where(id => id.IdUsuarioLogado == IdUsuario).ToList());
        }


        private MatchModel dbMatch = new MatchModel();
        private Match newMatch = new Match();
        private Guid g;
        private string IdUsuario;

        public ActionResult matchAdd(string id, bool status)
        {
            g = Guid.NewGuid();
            newMatch.IdMatch = g.ToString();
            newMatch.IdUsuario = User.Identity.GetUserId();
            newMatch.IdUsuarioCurtido = id;
            newMatch.Status = status;

            dbMatch.Match.Add(newMatch);
            dbMatch.SaveChanges();

            return RedirectToAction("TelaPrincipal", "Main");
        }

        public ActionResult Matches()
        {
            IdUsuario = User.Identity.GetUserId();
            return View()
            return View(dbMatches.vw_Matches_Reciprocos.Where(id => id.IdUsuario == IdUsuario).ToList());
        }
    }
}