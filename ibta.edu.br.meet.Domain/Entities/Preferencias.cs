namespace ibta.edu.br.meet.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Preferencias
    {
        [Key]
        public int IdPreferencia { get; set; }

        [Required]
        [StringLength(255)]
        public string Descricao { get; set; }
    }
}
