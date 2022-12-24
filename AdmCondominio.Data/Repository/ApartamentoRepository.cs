using AdmCondominio.Business.Contracts;
using AdmCondominio.Business.Entities;
using AdmCondominio.Data.Context;
using AdmCondominio.Data.Sql;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AdmCondominio.Data.Repository
{
    public class ApartamentoRepository : BaseRepository<Apartamento>, IApartamentoRepository
    {
        public ApartamentoRepository(AdmCondominioDbContext condominioContexto, IConfiguration config, ILogger<BaseRepository<Apartamento>> logger) : base(condominioContexto, config, logger)
        {
        }
    }
}
