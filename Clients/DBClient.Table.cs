using System.Data;
using MySql.Data.MySqlClient;
using SaPlaceta_api.Models;

namespace SaPlaceta_api.Clients;

partial class DBClient
{
    public Dictionary<int, IEnumerable<Pedido_Mesa>> GetAllTables()
    {
        var response = new Dictionary<int, IEnumerable<Pedido_Mesa>>();
        var sql = @"SELECT NUM_MESA, NOMBRE_PLATO, UNIDAD, PRECIO 
        FROM railway.MESA mesa 
        JOIN railway.PEDIDO pedido ON mesa.NUM_PEDIDO = pedido.NUM_PEDIDO
        JOIN railway.INVENTARIO i ON pedido.NUM_PLATO = i.NUM_PLATO;";

        var cmd = new MySqlCommand(sql, connection);

        var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            var tableId = reader.GetInt32(0);
            if (response.ContainsKey(tableId))
            {
                response.TryGetValue(tableId, out var actualOrders);
                var orders = actualOrders!.Append(new Pedido_Mesa(reader.GetString(1), reader.GetInt32(2), reader.GetFloat(3)));

                response.Remove(tableId);
                response.Add(tableId, orders);
            }
            else
            {
                response.TryAdd(tableId, new List<Pedido_Mesa>() { new Pedido_Mesa(reader.GetString(1), reader.GetInt32(2), reader.GetFloat(3)) });
            }
        }

        reader.Close();

        return response;
    }
}
