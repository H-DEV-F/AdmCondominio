using AdmCondominio.Api.ViewModels;
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

        public static explicit operator Bloco(BlocoViewModel obj)
        {
            return new Bloco()
            {
                CondominioId = obj.CondominioId,
                Nome = obj.Nome
            };
        }
    }
}
