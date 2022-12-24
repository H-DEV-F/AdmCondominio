using AdmCondominio.Business.Contracts;
using AdmCondominio.Business.Entities;
using AdmCondominio.Data.Context;
using AdmCondominio.Data.Sql;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AdmCondominio.Data.Repository
{
    public class CondominioRepository : BaseRepository<Condominio>, ICondominioRepository
    {
        public CondominioRepository(AdmCondominioDbContext condominioContexto, IConfiguration config, ILogger<BaseRepository<Condominio>> logger) : base(condominioContexto, config, logger)
        {
        }
    }
}
