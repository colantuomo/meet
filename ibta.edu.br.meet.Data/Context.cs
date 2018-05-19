using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ibta.edu.br.meet.Domain;

namespace ibta.edu.br.meet.Data
{
    public class Context : DbContext
    {
        public Context() : base("ibta.edu.br.DataBase")
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Preferencia> Preferencias { get; set; }
    }
}
