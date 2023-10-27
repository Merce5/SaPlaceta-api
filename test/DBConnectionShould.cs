using System.Data;
using FluentAssertions;
using Moq;
using MySql.Data.MySqlClient;
using SaPlaceta_api.Models;
using Xunit;

namespace SaPlaceta_api.Test;

public class DBConnectionShould
{
    [Fact]
    public void ConnectionShouldConnect()
    {
        MySqlConnection conn;
        string connectionString = "Server=containers-us-west-88.railway.app;Port=7901;User ID=root;Password=LrBOS6xyRVSu5gRKpkFq;Database=railway";

        conn = new MySqlConnection();
        conn.ConnectionString = connectionString;
        conn.Open();

        conn.Ping().Should().BeTrue();
        conn.Close();
    }

    [Fact]
    public void ShouldGetData()
    {
        MySqlConnection conn;
        string connectionString = "Server=containers-us-west-88.railway.app;Port=7901;User ID=root;Password=LrBOS6xyRVSu5gRKpkFq;Database=railway";

        conn = new MySqlConnection();
        conn.ConnectionString = connectionString;
        conn.Open();

        var cmd = new MySqlCommand("INVENTARIO", conn);
        cmd.CommandType = CommandType.TableDirect;

        var reader = cmd.ExecuteReader();
        reader.Read();
        var item = new PLATO(reader.GetInt32(0), reader.GetString(1), reader.GetDecimal(2), reader.GetInt32(3));

        reader.Close();
        conn.Close();

        item.Should().NotBe(null);
    }
}
