using System.Data;
using MySql.Data.MySqlClient;
using SaPlaceta_api.Models;

namespace SaPlaceta_api.Clients;

partial class DBClient
{
    public IEnumerable<MESA> GetAllTables()
    {
        var cmd = new MySqlCommand("MESA", connection);
        cmd.CommandType = CommandType.TableDirect;

        var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            yield return new MESA(reader.GetInt32(0), reader.GetInt32(1));
        }

        reader.Close();
    }
}
