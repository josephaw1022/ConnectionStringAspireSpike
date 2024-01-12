namespace MinApiExample;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.AddServiceDefaults();

        // Add services to the container.
        builder.Services.AddAuthorization();


        var app = builder.Build();


        app.MapDefaultEndpoints();

        // Configure the HTTP request pipeline.

        app.UseAuthorization();


        app.MapGet("/", (IConfiguration configuration) =>
        {
            // make the configuration values a dictionary<string, string> and return it.
            var cache1 = configuration.GetConnectionString("cache1");
            var cache2 = configuration.GetConnectionString("cache2");
            var cache3 = configuration.GetConnectionString("cache3");

            return Results.Ok(new
            {
                cache1,
                cache2,
                cache3
            });
        });

        app.Run();
    }
}
