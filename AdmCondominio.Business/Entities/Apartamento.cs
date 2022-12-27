using AdmCondominio.Api.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AdmCondominio.Business.Entities
{
    public class Apartamento
    {
        [Key]
        public Guid Id { get; set; }
        public Guid BlocoId { get; set; }
        [JsonIgnore]
        public virtual Bloco Bloco { get; set; }
        public string Identificador { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public DateTime? DataAtualizacao { get; set; }
        public virtual ICollection<Morador> Moradores { get; set; }

        public static explicit operator Apartamento(ApartamentoViewModel obj)
        {
            return new Apartamento()
            {
                BlocoId = obj.BlocoId,
                Identificador = obj.Identificador
            };
        }
    }
}
