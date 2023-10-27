using System.Net;
using SaPlaceta_api.Clients;
namespace SaPlaceta_api;

internal class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.WebHost.ConfigureKestrel(op =>
            {
                op.Listen(new IPAddress(new byte[4] { 0, 0, 0, 0 }), 3000);
            });
        builder.Services.AddControllers();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddTransient<IDBClient, DBClient>(_ => new DBClient(builder.Configuration));

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}
