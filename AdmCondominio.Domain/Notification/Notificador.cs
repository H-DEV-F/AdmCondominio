﻿using AdmCondominio.Domain.Notification.Interfaces;

namespace AdmCondominio.Domain.Notification
{
    public class Notificador : INotificador
    {
        private readonly List<Notificacao> _notificacoes;
        public Notificador()
        {
            _notificacoes = new List<Notificacao>();
        }

        public void Handle(Notificacao notificacao) 
        {
            _notificacoes.Add(notificacao);
        }

        public List<Notificacao> ObterNotificacoes()
        {
            return _notificacoes;
        }

        public bool TemNotificacao()
        {
            return !_notificacoes.Any();
        }
    }
}
