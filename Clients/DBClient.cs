using MySql.Data.MySqlClient;

namespace SaPlaceta_api.Clients
{
    partial class DBClient : IDBClient
    {
        public MySqlConnection connection;
        public string ConnectionString;
        public DBClient(IConfiguration configuration)
        {
            ConnectionString = configuration.GetValue<string>("ConnectionString");
            connection = new MySqlConnection(ConnectionString);
            connection.Open();
        }
    }
}