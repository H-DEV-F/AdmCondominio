using AdmCondominio.Domain.Contracts;
using AdmCondominio.Domain.Entities;
using AdmCondominio.Infra.Context;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AdmCondominio.Domain.Repositories
{
    public class CondominioRepository : BaseRepository<Condominio>, ICondominioRepository
    {
        public CondominioRepository(AdmCondominioDbContext condominioContexto, IConfiguration config, ILogger<BaseRepository<Condominio>> logger) : base(condominioContexto, config, logger)
        {
        }
    }
}
