using AdmCondominio.Domain.Sql;
using AdmCondominio.Infra.Context;
using Microsoft.Extensions.Logging;
using AdmCondominio.Domain.Contracts;
using Microsoft.Extensions.Configuration;

namespace AdmCondominio.Domain.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly IConfiguration _config;
        protected readonly ILogger<BaseRepository<TEntity>> _logger;
        protected readonly AdmCondominioDbContext AdmCondominioContexto;

        public BaseRepository(AdmCondominioDbContext circlesPratasContexto, IConfiguration config, ILogger<BaseRepository<TEntity>> logger)
        {
            _config = config;
            _logger = logger;
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

        public virtual async Task<TEntity> ObterPorId(Guid id)
        {
            return await Dapper<TEntity>.ObterPorId(_config, _logger, id);
        }

        public virtual async Task<IEnumerable<TEntity>> ObterTodos()
        {
            return await Dapper<TEntity>.ObterTodos(_config, _logger);
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