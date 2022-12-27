using AdmCondominio.Api.ViewModels;
using AdmCondominio.Business.Contracts;
using AdmCondominio.Business.Entities;
using AdmCondominio.Business.Notification.Interfaces;
using AdmCondominio.Business.ViewModels;
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
        [Route("{id}")]
        public async Task<Morador> ObterPorId(Guid id)
        {
            return await _moradorRepository.ObterPorId(id);
        }

        [HttpGet]
        public async Task<IEnumerable<Morador>> ObterTodos()
        {
            return await _moradorRepository.ObterTodos();
        }

        [HttpPost]
        public async void Adicionar(MoradorViewModel data)
        {
            await _moradorRepository.Adicionar((Morador)data);
        }

        [HttpDelete]
        public async void Remover(MoradorViewModel data)
        {
            await _moradorRepository.Adicionar((Morador)data);
        }
    }
}
