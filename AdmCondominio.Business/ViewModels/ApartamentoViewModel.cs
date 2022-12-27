using System.ComponentModel.DataAnnotations;

namespace AdmCondominio.Api.ViewModels
{
    public class ApartamentoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Guid BlocoId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Identificador { get; set; }
    }
}
