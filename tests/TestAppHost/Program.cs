using WorkHub.Shared;

namespace WorkHub.TestAppHost;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = DistributedApplication.CreateBuilder(args);

        // Azure əvəzinə birbaşa standart Aspire PostgreSQL metodu:
        var databaseServer = builder.AddPostgres(Services.DatabaseServer)
            .AddDatabase(Services.Database);

        builder.Build().Run();
    }
}
