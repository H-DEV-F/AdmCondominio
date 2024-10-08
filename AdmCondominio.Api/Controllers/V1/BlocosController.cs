﻿using AdmCondominio.Api.ViewModels;
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
    public class BlocosController : MainController
    {
        private readonly IBlocoRepository _blocoRepository;
        public BlocosController(IBlocoRepository blocoRepositoy, 
            INotificador notificador, IUser user) : base(notificador, user)
        {
            _blocoRepository = blocoRepositoy;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<Bloco> ObterPorId(Guid id)
        {
            return await _blocoRepository.ObterPorId(id);
        }

        [HttpGet]
        public async Task<IEnumerable<Bloco>> ObterTodos()
        {
            return await _blocoRepository.ObterTodos();
        }

        [HttpPost]
        public async void Adicionar(BlocoViewModel data)
        {
            await _blocoRepository.Adicionar((Bloco)data);
        }

        [HttpDelete]
        public async void Remover(BlocoViewModel data)
        {
            await _blocoRepository.Adicionar((Bloco)data);
        }
    }
}
