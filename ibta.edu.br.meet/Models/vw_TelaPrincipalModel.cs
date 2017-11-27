namespace ibta.edu.br.meet.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class vw_TelaPrincipalModel : DbContext
    {
        public vw_TelaPrincipalModel()
            : base("name=vw_TelaPrincipalModel")
        {
        }

        public virtual DbSet<vw_TelaPrincipal> vw_TelaPrincipal { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
