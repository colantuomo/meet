namespace ibta.edu.br.meet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_TelaPrincipal
    {
        [Key]
        [Column(Order = 0)]
        public string IdUsuarioLogado { get; set; }

        [Key]
        [Column(Order = 1)]
        public string IdUsuario { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string Nome { get; set; }

        public int? Idade { get; set; }
    }
}
