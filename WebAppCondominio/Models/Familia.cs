
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppCondominio.Models
{
    public class Familia
    {
        public int FamiliaId { get; set; }
        [ForeignKey("FamiliaId")]
        public string Nome { get; set; }
        public int CondominioID { get; set; }
        [ForeignKey("CondominioID")]
        public string Apto { get; set; }
        public Condominio Condominio { get; set; }
        public virtual ICollection<Morador> Morador { get; set; }

    }
}
