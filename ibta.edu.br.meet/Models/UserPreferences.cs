using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ibta.edu.br.meet.Models
{
    public class UserPreferences
    {
        public DateTime dataNasc { get; set; }
        public string nome { get; set; }
        public string sexo { get; set; }
        public string sexoAlvo { get; set; }
    }
}