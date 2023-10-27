using Microsoft.AspNetCore.Mvc;
using SaPlaceta_api.Clients;
using SaPlaceta_api.Models;

namespace SaPlaceta_api.Controllers;

[Controller]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private IDBClient _client;
    public OrderController(IDBClient client)
    {
        _client = client;
    }

    [HttpGet]
    public IEnumerable<PEDIDO> GetAllOrders()
    {
        return _client.GetAllOrders();
    }

    [HttpGet("{date}")]
    public IEnumerable<PEDIDO> GetAllOrdersByDate(DateTime date)
    {
        return _client.GetAllOrdersByDate(date);
    }
}
