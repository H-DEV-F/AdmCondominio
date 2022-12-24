using AdmCondominio.Business.Contracts;
using AdmCondominio.Business.Entities;
using AdmCondominio.Data.Context;
using AdmCondominio.Data.Sql;
using Microsoft.Extensions.Configuration;

namespace AdmCondominio.Data.Repository
{
    public class ApartamentoRepository : BaseRepository<Apartamento>, IApartamentoRepository
    {
        public ApartamentoRepository(AdmCondominioDbContext condominioContexto, IConfiguration config) : base(condominioContexto, config)
        {
        }
    }
}
