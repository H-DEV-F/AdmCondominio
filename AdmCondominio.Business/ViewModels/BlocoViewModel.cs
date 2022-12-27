using System.ComponentModel.DataAnnotations;

namespace AdmCondominio.Api.ViewModels
{
    public class BlocoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Guid CondominioId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Nome { get; set; }
    }
}
