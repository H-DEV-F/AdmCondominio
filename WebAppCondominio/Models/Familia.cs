using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCondominio.Models
{
    public class Familia
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Id_Condominio { get; set; }
        public string Apto { get; set; }
    }
}
