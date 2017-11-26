namespace ibta.edu.br.meet.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PreferenciasModel : DbContext
    {
        public PreferenciasModel()
            : base("name=PreferenciasModel")
        {
        }

        public virtual DbSet<Preferencias> Preferencias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
