namespace ibta.edu.br.meet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_Matches_Reciprocos
    {
        [Key]
        [Column(Order = 0)]
        public string IdUsuario { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string Nome { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Status { get; set; }
    }
}
