using Microsoft.AspNetCore.Mvc;
using SaPlaceta_api.Clients;
using SaPlaceta_api.Models;

namespace SaPlaceta_api.Controllers;

[Controller]
[Route("[controller]")]
public class InventoryController : ControllerBase
{
    private IDBClient _client;
    public InventoryController(IDBClient client)
    {
        _client = client;
    }

    [HttpGet]
    public IEnumerable<PLATO> GetInventory()
    {
        return _client.GetAllInventory();
    }
}
