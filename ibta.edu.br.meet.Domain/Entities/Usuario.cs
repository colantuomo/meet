namespace ibta.edu.br.meet.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuarios")]
    public partial class Usuario
    {
        [Key]
        public string IdUsuario { get; set; }

        [Required]
        [StringLength(255)]
        public string Nome { get; set; }

        [StringLength(255)]
        public string Nickname { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataNascimento { get; set; }

        public byte Sexo { get; set; }
    }
}
