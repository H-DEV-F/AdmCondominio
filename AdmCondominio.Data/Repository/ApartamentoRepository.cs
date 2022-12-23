using AdmCondominio.Business.Contracts;
using AdmCondominio.Business.Entities;
using AdmCondominio.Data.Context;

namespace AdmCondominio.Data.Repository
{
    public class ApartamentoRepository : BaseRepository<Apartamento>, IApartamentoRepository
    {
        public ApartamentoRepository(AdmCondominioDbContext condominioContexto) : base(condominioContexto)
        {
        }
    }
}
