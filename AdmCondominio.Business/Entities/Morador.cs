
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AdmCondominio.Business.Entities
{
    public class Morador
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ApartamentoId { get; set; }
        [JsonIgnore]
        public virtual Apartamento Apartamento { get; set; }
        public string Nome { get; set; }
        public int Pets { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public DateTime? DataAtualizacao { get; set; }
    }
}
