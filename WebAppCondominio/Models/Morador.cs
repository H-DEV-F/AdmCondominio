
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppCondominio.Models
{
    public class Morador
    {
        public int MoradorID { get; set; }
        public int FamiliaID { get; set; }
        [ForeignKey("FamiliaID")]
        public string Nome { get; set; }
        public Familia Familia { get; set; }
        public int QuantidadeBichosEstimacao { get; set; }
    }
}
