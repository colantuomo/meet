namespace ibta.edu.br.meet.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Collections.Generic;

    public partial class UsuarioModel : DbContext
    {
        public UsuarioModel()
            : base("name=UsuarioModel")
        {
        }

        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }

        public List<Usuario> getAllUsers(){
            return Usuario.ToList();
        }


    }
}
