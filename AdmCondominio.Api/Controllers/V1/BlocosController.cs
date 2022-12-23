using AdmCondominio.Business.Contracts;
using AdmCondominio.Business.Entities;
using AdmCondominio.Business.Notification.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdmCondominio.Controllers.V1
{
    [Authorize]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/blocos")]
    public class BlocosController : MainController
    {
        private readonly IBlocoRepository _blocoRepository;
        public BlocosController(IBlocoRepository blocoRepositoy, 
            INotificador notificador, IUser user) : base(notificador, user)
        {
            _blocoRepository = blocoRepositoy;
        }

        [HttpGet]
        public async Task<IEnumerable<Bloco>> ObterTodos()
        {
            return await _blocoRepository.ObterTodos();
        }
    }
}
