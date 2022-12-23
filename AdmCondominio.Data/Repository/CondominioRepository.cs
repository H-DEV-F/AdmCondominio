using AdmCondominio.Business.Contracts;
using AdmCondominio.Business.Entities;
using AdmCondominio.Data.Context;

namespace AdmCondominio.Data.Repository
{
    public class CondominioRepository : BaseRepository<Condominio>, ICondominioRepository
    {
        public CondominioRepository(AdmCondominioDbContext condominioContexto) : base(condominioContexto)
        {
        }
    }
}
