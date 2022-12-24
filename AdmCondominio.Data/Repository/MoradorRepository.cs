using AdmCondominio.Business.Contracts;
using AdmCondominio.Business.Entities;
using AdmCondominio.Data.Context;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AdmCondominio.Data.Repository
{
    public class MoradorRepository : BaseRepository<Morador>, IMoradorRepository
    {
        public MoradorRepository(AdmCondominioDbContext condominioContexto, IConfiguration config, ILogger<BaseRepository<Morador>> logger) : base(condominioContexto, config, logger)
        {
        }
    }
}
