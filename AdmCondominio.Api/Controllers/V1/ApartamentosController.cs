using Microsoft.AspNetCore.Mvc;
using AdmCondominio.Api.ViewModels;
using AdmCondominio.Domain.Entities;
using AdmCondominio.Domain.Contracts;
using Microsoft.AspNetCore.Authorization;
using AdmCondominio.Domain.Notification.Interfaces;

namespace AdmCondominio.Api.Controllers.V1
{
    [Authorize]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ApatamentosController : MainController
    {
        private readonly IApartamentoRepository _apartamentoRepository;
        public ApatamentosController(IApartamentoRepository apartamentoRepository, INotificador notificador, IUser user) : base(notificador, user)
        {
            _apartamentoRepository = apartamentoRepository;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<Apartamento> ObterPorId(Guid id)
        {
            return await _apartamentoRepository.ObterPorId(id);
        }

        [HttpGet]
        public async Task<IEnumerable<Apartamento>> ObterTodos()
        {
            return await _apartamentoRepository.ObterTodos();
        }

        [HttpPost]
        public async void Adicionar(ApartamentoViewModel data)
        {
            await _apartamentoRepository.Adicionar((Apartamento)data);
        }

        [HttpDelete]
        public async void Remover(ApartamentoViewModel data)
        {
            await _apartamentoRepository.Remover((Apartamento)data);
        }
    }
}
