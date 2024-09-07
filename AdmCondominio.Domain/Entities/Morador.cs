using AdmCondominio.Domain.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AdmCondominio.Domain.Entities
{
    public class Morador
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ApartamentoId { get; set; }
        [JsonIgnore]
        public virtual Apartamento Apartamento { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int Pets { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public DateTime? DataAtualizacao { get; set; }

        public static explicit operator Morador(MoradorViewModel obj)
        {
            return new Morador()
            {
                Nome = obj.Nome,
                Telefone = obj.Telefone,
                Pets = obj.Pets,
                ApartamentoId = obj.ApartamentoId
            };
        }
    }
}
