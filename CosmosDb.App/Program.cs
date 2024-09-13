
using Microsoft.Extensions.Configuration;
using static System.Console;

namespace CosmosDb.App;

public class Program
{
    static async Task Main()
    {
        WriteLine("Hello, World!");
        await Task.CompletedTask;

        var config = GetConfig();
    }

	private static IConfiguration GetConfig()
	{
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appSettings.json", optional: true)
            .AddUserSecrets<Program>();

        return builder.Build();
	}
}
