using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace AdmCondominio.Data.Sql
{
    public static class Dapper<TEntity>
    {
        public static async Task<TEntity?> ObterPorId(IConfiguration config, Guid id)
        {
            using (var db = new SqlConnection(config.GetConnectionString("DefaultConnection")))
            {
                try
                {
                    await db.OpenAsync();
                    return await db.QueryFirstAsync<TEntity>(Query(), new Params() { Filter = $" WHERE Id = '{id}'" });
                }
                catch (Exception ex)
                {
                    return default;
                }
            }
        }

        public static async Task<IEnumerable<TEntity>?> ObterTodos(IConfiguration config)
        {
            var t = config.GetConnectionString("DefaultConnection");
            using (var db = new SqlConnection(config.GetConnectionString("DefaultConnection")))
            {
                try
                {
                    await db.OpenAsync();
                    return await db.QueryAsync<TEntity>(Query(), new Params() { Filter = "" });
                }
                catch (Exception ex)
                {
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
