using AdmCondominio.Business.Contracts;
using AdmCondominio.Data.Context;
using AdmCondominio.Data.Sql;
using Microsoft.Extensions.Configuration;

namespace AdmCondominio.Data.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly AdmCondominioDbContext AdmCondominioContexto;
        protected readonly IConfiguration _config;

        public BaseRepository(AdmCondominioDbContext circlesPratasContexto, IConfiguration config)
        {
            AdmCondominioContexto = circlesPratasContexto;
            _config = config;
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

        public virtual async Task<TEntity> ObterPorId(Guid id)
        {
            return await Dapper<TEntity>.ObterPorId(_config, id);

            //return await AdmCondominioContexto.Set<TEntity>().FindAsync(id);
        }

        public virtual async Task<IEnumerable<TEntity>> ObterTodos()
        {
            return await Dapper<TEntity>.ObterTodos(_config);
            //return await Task.FromResult(AdmCondominioContexto.Set<TEntity>().ToList());
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
