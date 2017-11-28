namespace ibta.edu.br.meet.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class UsuarioPreferenciasModel : DbContext
    {
        public UsuarioPreferenciasModel()
            : base("name=UsuarioPreferenciasModel")
        {
        }

        public virtual DbSet<Usuario_Preferencias> Usuario_Preferencias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
