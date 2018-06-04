using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using ibta.edu.br.meet.Models;
using ibta.edu.br.meet.Data;
using ibta.edu.br.meet.Domain;

namespace ibta.edu.br.meet.Controllers
{
    [Authorize]
    public class MainController : Controller
    {
        private vw_TelaPrincipalModel dbTelaPrincipal = new vw_TelaPrincipalModel();
        private vw_MatchesModel dbMatches = new vw_MatchesModel();
        private Context db = new Context();

        // GET: Main
        public ActionResult TelaPrincipal()
        {
            IdUsuario = User.Identity.GetUserId();
            var res = db.Usuarios.SqlQuery("SELECT Usuarios.Nome, Usuarios.DataNascimento FROM Usuarios " +
                "INNER JOIN Usuario_Preferencias ON Usuarios.idUsuario = Usuario_Preferencias.idUsuario " +
                "WHERE Usuarios.idUsuario = "+IdUsuario).ToList();
            return View(res);
        }

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

            db.Matchs.Add(newMatch);
            db.SaveChanges();

            return RedirectToAction("TelaPrincipal", "Main");
        }

        public ActionResult Matches()
        {
            var resultado = db.Matchs
                .Join(db.Usuarios, matches => matches.IdUsuario, usuario => usuario.IdUsuario, (matches, usuario) => new { matches, usuario })
                .Join(db.Usuarios, matches2 => matches2.matches.IdUsuarioCurtido, usuario2 => usuario2.IdUsuario, (matches, usuario2) => new { matches, usuario2 })
                .Select(x => new
                {
                    IdUsuario = x.matches.usuario.IdUsuario,
                    IdUsuarioCurtido = x.usuario2.IdUsuario,
                    NomeUsuario = x.matches.usuario.IdUsuario,
                    NomeUsuarioCurtido = x.usuario2.Nome
                }
                ).ToList();

            return View(resultado);
            //IdUsuario = User.Identity.GetUserId();
            //return View(dbMatches.vw_Matches_Reciprocos.Where(id => id.IdUsuario == IdUsuario).ToList());
        }
    }
}
