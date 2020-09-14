
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppCondominio.Models
{
    public class Condominio
    {
        public int CondominioID { get; set; }
        public string Nome { get; set; }
        public string Bairro { get; set; }
        [ForeignKey("CondominioID")]
        public virtual ICollection<Familia> Familia { get; set; }
    }
}
