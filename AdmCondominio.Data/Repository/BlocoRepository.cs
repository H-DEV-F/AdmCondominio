using AdmCondominio.Business.Contracts;
using AdmCondominio.Business.Entities;
using AdmCondominio.Data.Context;
using AdmCondominio.Data.Sql;
using Microsoft.Extensions.Configuration;

namespace AdmCondominio.Data.Repository
{
    public class BlocoRepository : BaseRepository<Bloco>, IBlocoRepository
    {
        public BlocoRepository(AdmCondominioDbContext condominioContexto, IConfiguration config) : base(condominioContexto, config)
        {
        }
    }
}
