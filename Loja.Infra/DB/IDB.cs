using System.Data;

namespace Loja.Infra.DB
{
    public interface IDB
    {
        IDbConnection GetConnection();
    }
}
