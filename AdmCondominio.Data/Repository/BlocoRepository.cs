using AdmCondominio.Business.Contracts;
using AdmCondominio.Business.Entities;
using AdmCondominio.Data.Context;

namespace AdmCondominio.Data.Repository
{
    public class BlocoRepository : BaseRepository<Bloco>, IBlocoRepository
    {
        public BlocoRepository(AdmCondominioDbContext condominioContexto) : base(condominioContexto)
        {
        }
    }
}
