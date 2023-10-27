using Microsoft.AspNetCore.Mvc;
using SaPlaceta_api.Clients;
using SaPlaceta_api.Models;

namespace SaPlaceta_api.Controllers;

[Controller]
[Route("[controller]")]
public class TableController : ControllerBase
{
    private IDBClient _client;
    public TableController(IDBClient client)
    {
        _client = client;
    }

    [HttpGet]
    public IEnumerable<MESA> GetInventory()
    {
        return _client.GetAllTables();
    }
}
