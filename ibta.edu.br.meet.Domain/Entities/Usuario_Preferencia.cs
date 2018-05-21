namespace ibta.edu.br.meet.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario_Preferencias")]
    public partial class Usuario_Preferencia
    {
        [Key]
        [Column(Order = 0)]
        public string IdUsuario { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte Sexo { get; set; }

        public byte? IdadeInicial { get; set; }

        public byte? IdadeFinal { get; set; }
    }
}
