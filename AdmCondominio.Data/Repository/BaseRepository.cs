using AdmCondominio.Business.Contracts;
using AdmCondominio.Data.Context;

namespace AdmCondominio.Data.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly AdmCondominioDbContext AdmCondominioContexto;

        public BaseRepository(AdmCondominioDbContext circlesPratasContexto)
        {
            AdmCondominioContexto = circlesPratasContexto;
        }

        public virtual async Task Adicionar(TEntity entity)
        {
            AdmCondominioContexto.Set<TEntity>().Add(entity);
            await AdmCondominioContexto.SaveChangesAsync();
        }

        public virtual async Task Atualizar(TEntity entity)
        {
            AdmCondominioContexto.Set<TEntity>().Update(entity);
            await AdmCondominioContexto.SaveChangesAsync();
        }

        public virtual async Task<TEntity> ObterPorId(int id)
        {
            return await AdmCondominioContexto.Set<TEntity>().FindAsync(id);
        }

        public virtual async Task<IEnumerable<TEntity>> ObterTodos()
        {
            return await Task.FromResult(AdmCondominioContexto.Set<TEntity>().ToList());
        }

        public virtual async Task Remover(TEntity entity)
        {
            AdmCondominioContexto.Remove(entity);
            await AdmCondominioContexto.SaveChangesAsync();
        }

        public void Dispose()
        {
            AdmCondominioContexto.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
