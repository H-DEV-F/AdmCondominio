using AdmCondominio.Business.Contracts;
using AdmCondominio.Business.Notification.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdmCondominio.Controllers.V1
{
    [Authorize]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/moradores")]
    public class MoradoresController : MainController
    {
        private readonly IMoradorRepository _moradorRepository;
        public MoradoresController(IMoradorRepository moradorRepository, INotificador notificador, IUser user) : base(notificador, user)
        {
            _moradorRepository = moradorRepository;
        }

        [HttpGet]
        public async Task<string> ObterTodos()
        {
            return await Task.FromResult("");
        }
    }
}
