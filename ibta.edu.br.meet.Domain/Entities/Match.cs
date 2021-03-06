namespace ibta.edu.br.meet.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Matches")]
    public partial class Match
    {
        [Key]
        public string IdMatch { get; set; }

        [Required]
        [StringLength(128)]
        public string IdUsuario { get; set; }

        [Required]
        [StringLength(128)]
        public string IdUsuarioCurtido { get; set; }

        public bool Status { get; set; }
    }
}
