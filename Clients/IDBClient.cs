using SaPlaceta_api.Models;

namespace SaPlaceta_api.Clients;

public interface IDBClient
{
    IEnumerable<PLATO> GetAllInventory();
    IEnumerable<PEDIDO> GetAllOrders();
    IEnumerable<PEDIDO> GetAllOrdersByDate(DateTime date);
    IEnumerable<MESA> GetAllTables();
}
