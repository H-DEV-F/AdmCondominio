using AdmCondominio.Domain.Contracts;
using AdmCondominio.Domain.Entities;
using AdmCondominio.Infra.Context;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AdmCondominio.Domain.Repositories
{
    public class BlocoRepository : BaseRepository<Bloco>, IBlocoRepository
    {
        public BlocoRepository(AdmCondominioDbContext condominioContexto, IConfiguration config, ILogger<BaseRepository<Bloco>> logger) : base(condominioContexto, config, logger)
        {
        }
    }
}
