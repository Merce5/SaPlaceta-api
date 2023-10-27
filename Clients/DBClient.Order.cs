using System.Data;
using MySql.Data.MySqlClient;
using SaPlaceta_api.Models;

namespace SaPlaceta_api.Clients;

partial class DBClient
{
    public IEnumerable<PEDIDO> GetAllOrders()
    {
        var cmd = new MySqlCommand("PEDIDO", connection);
        cmd.CommandType = CommandType.TableDirect;

        var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            yield return new PEDIDO(reader.GetInt32(0), reader.GetInt32(1), reader.GetDateTime(2), reader.GetInt32(3));
        }

        reader.Close();
    }

    public IEnumerable<PEDIDO> GetAllOrdersByDate(DateTime date)
    {
        var cmd = new MySqlCommand($"SELECT * FROM PEDIDO WHERE DIA = '{date.ToString("yyy-MM-dd")}'", connection);

        var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            yield return new PEDIDO(reader.GetInt32(0), reader.GetInt32(1), reader.GetDateTime(2), reader.GetInt32(3));
        }

        reader.Close();
    }
}
