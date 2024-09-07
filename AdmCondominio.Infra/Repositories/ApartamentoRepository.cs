using AdmCondominio.Infra.Context;
using Microsoft.Extensions.Logging;
using AdmCondominio.Domain.Entities;
using AdmCondominio.Domain.Contracts;
using Microsoft.Extensions.Configuration;

namespace AdmCondominio.Domain.Repositories
{
    public class ApartamentoRepository : BaseRepository<Apartamento>, IApartamentoRepository
    {
        public ApartamentoRepository(AdmCondominioDbContext condominioContexto, IConfiguration config, ILogger<BaseRepository<Apartamento>> logger) : base(condominioContexto, config, logger)
        {
        }
    }
}
