using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCondominio.Models
{
    public class Morador
    {
        public int Id { get; set; }
        public int Id_Familia { get; set; }
        public string Nome { get; set; }
        public int QuantidadeBichosEstimacao { get; set; }
    }
}
