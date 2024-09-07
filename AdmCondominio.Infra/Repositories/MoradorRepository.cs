using AdmCondominio.Domain.Contracts;
using AdmCondominio.Domain.Entities;
using AdmCondominio.Infra.Context;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AdmCondominio.Domain.Repositories
{
    public class MoradorRepository : BaseRepository<Morador>, IMoradorRepository
    {
        public MoradorRepository(AdmCondominioDbContext condominioContexto, IConfiguration config, ILogger<BaseRepository<Morador>> logger) : base(condominioContexto, config, logger)
        {
        }
    }
}