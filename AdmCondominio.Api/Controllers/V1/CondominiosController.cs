using AdmCondominio.Api.ViewModels;
using AdmCondominio.Domain.Contracts;
using AdmCondominio.Domain.Entities;
using AdmCondominio.Domain.Notification.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdmCondominio.Api.Controllers.V1
{
    [Authorize]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class CondominiosController : MainController
    {
        private readonly ICondominioRepository _condominioRepository;
        public CondominiosController(ICondominioRepository condominioRepository, INotificador notificador, IUser user) : base(notificador, user)
        {
            _condominioRepository = condominioRepository;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<Condominio> ObterPorId(Guid id)
        {
            return await _condominioRepository.ObterPorId(id);
        }

        [HttpGet]
        public async Task<IEnumerable<Condominio>> ObterTodos()
        {
            return await _condominioRepository.ObterTodos();
        }

        [HttpPost]
        public async void Adicionar(CondominioViewModel data)
        {
            await _condominioRepository.Adicionar((Condominio)data);
        }

        [HttpDelete]
        public async void Remover(CondominioViewModel data)
        {
            await _condominioRepository.Adicionar((Condominio)data);
        }
    }
}
