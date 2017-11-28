namespace ibta.edu.br.meet.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class vw_MatchesModel : DbContext
    {
        public vw_MatchesModel()
            : base("name=vw_MatchesModel")
        {
        }

        public virtual DbSet<vw_Matches_Reciprocos> vw_Matches_Reciprocos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
