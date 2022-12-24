using AdmCondominio.Business.Contracts;
using AdmCondominio.Business.Entities;
using AdmCondominio.Data.Context;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AdmCondominio.Data.Repository
{
    public class BlocoRepository : BaseRepository<Bloco>, IBlocoRepository
    {
        public BlocoRepository(AdmCondominioDbContext condominioContexto, IConfiguration config, ILogger<BaseRepository<Bloco>> logger) : base(condominioContexto, config, logger)
        {
        }
    }
}
