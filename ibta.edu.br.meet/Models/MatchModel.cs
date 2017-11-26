namespace ibta.edu.br.meet.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MatchModel : DbContext
    {
        public MatchModel()
            : base("name=MatchModel")
        {
        }

        public virtual DbSet<Match> Match { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
