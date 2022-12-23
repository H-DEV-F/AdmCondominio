using AdmCondominio.Business.Contracts;
using AdmCondominio.Business.Notification.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdmCondominio.Controllers.V1
{
    [Authorize]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/condominios")]
    public class CondominiosController : MainController
    {
        private readonly ICondominioRepository _condominioRepository;
        public CondominiosController(ICondominioRepository condominioRepository, INotificador notificador, IUser user) : base(notificador, user)
        {
            _condominioRepository = condominioRepository;
        }

        [HttpGet]
        public async Task<string> ObterTodos()
        {
            return await Task.FromResult("");
        }
    }
}
