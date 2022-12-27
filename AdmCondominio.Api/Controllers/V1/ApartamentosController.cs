using AdmCondominio.Api.ViewModels;
using AdmCondominio.Business.Contracts;
using AdmCondominio.Business.Entities;
using AdmCondominio.Business.Notification.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdmCondominio.Controllers.V1
{
    [Authorize]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/apartamentos")]
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
