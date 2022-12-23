using AdmCondominio.Business.Contracts;
using AdmCondominio.Business.Entities;
using AdmCondominio.Data.Context;

namespace AdmCondominio.Data.Repository
{
    public class MoradorRepository : BaseRepository<Morador>, IMoradorRepository
    {
        public MoradorRepository(AdmCondominioDbContext condominioContexto) : base(condominioContexto)
        {
        }
    }
}
