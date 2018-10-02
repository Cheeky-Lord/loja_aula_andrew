using System.Data;
using System.Data.SqlClient;
namespace Loja.Infra.DB
{
    public class MSSQLDB : IDB
    {
        public IDbConnection GetConnection()
        {
            return new SqlConnection(@"Server=DESKTOP-6QC1PQO; Database=loja_aula_andrew; USER=sa, PASSWORD=123");
        }
    }
}
