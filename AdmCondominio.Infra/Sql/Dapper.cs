using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AdmCondominio.Domain.Sql
{
    public static class Dapper<TEntity>
    {
        public static async Task<TEntity?> ObterPorId(IConfiguration config, ILogger logger, Guid id)
        {
            using (var db = new SqlConnection(config.GetConnectionString("DefaultConnection")))
            {
                try
                {
                    logger.LogInformation("Conectando ao banco de dados");

                    await db.OpenAsync();
                    return await db.QueryFirstOrDefaultAsync<TEntity>(Query(), new Params() { Filter = $" WHERE Id = '{id}'" });
                }
                catch (Exception ex)
                {
                    logger.LogError(ex.Message);
                    return default;
                }
            }
        }

        public static async Task<IEnumerable<TEntity>?> ObterTodos(IConfiguration config, ILogger logger)
        {
            using (var db = new SqlConnection(config.GetConnectionString("DefaultConnection")))
            {
                try
                {
                    logger.LogInformation("Conectando ao banco de dados");

                    await db.OpenAsync();
                    return await db.QueryAsync<TEntity>(Query(), new Params() { Filter = "" });
                }
                catch (Exception ex)
                {
                    logger.LogError(ex.Message);
                    return default;
                }
            }
        }

        private static string Query()
        {
            switch (nameof(TEntity))
            {
                case "Condominio":
                    return "SELECT * FROM Condominios @filter";
                case "Apartamento":
                    return "SELECT * FROM Apartamentos @filter";
                case "Bloco":
                    return "SELECT * FROM Blocos @filter";
                case "Morador":
                    return "SELECT * FROM Moradores @filter";
                default:
                    return "SELECT 1";
            }
        }
    }
}
