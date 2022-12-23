using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AdmCondominio.Business.Entities
{
    public class Bloco
    {
        [Key]
        public Guid Id { get; set; }
        public Guid CondominioId { get; set; }
        [JsonIgnore]
        public virtual Condominio Condominio { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public DateTime? DataAtualizacao { get; set; }
    }
}
