using AdmCondominio.Domain.Contracts;
using AdmCondominio.Domain.Entities;
using AdmCondominio.Domain.Notification.Interfaces;
using AdmCondominio.Domain.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdmCondominio.Api.Controllers.V1
{
    [Authorize]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
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
