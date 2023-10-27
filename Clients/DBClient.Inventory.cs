using System.Data;
using MySql.Data.MySqlClient;
using SaPlaceta_api.Models;

namespace SaPlaceta_api.Clients;

partial class DBClient
{
    public IEnumerable<PLATO> GetAllInventory()
    {
        var cmd = new MySqlCommand("INVENTARIO", connection);
        cmd.CommandType = CommandType.TableDirect;

        var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            yield return new PLATO(reader.GetInt32(0), reader.GetString(1), reader.GetDecimal(2), reader.GetInt32(3));
        }

        reader.Close();
    }
}
