using AdmCondominio.Api.ViewModels;

namespace AdmCondominio.Business.Entities
{
    public class Condominio
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int CEP { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public DateTime? DataAtualizacao { get; set; }
        public virtual ICollection<Bloco> Blocos { get; set; }

        public static explicit operator Condominio(CondominioViewModel obj)
        {
            return new Condominio()
            {
                Nome = obj.Nome,
                Telefone = obj.Telefone,
                Endereco = obj.Endereco,
                Numero = obj.Numero,
                Complemento = obj.Complemento,
                Bairro = obj.Bairro,
                Cidade = obj.Cidade,
                Estado = obj.Estado,
                CEP = obj.CEP
            };
        }
    }
}
