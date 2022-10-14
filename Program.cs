var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Minimal API .NET 6 para catálogo de música!");

app.Run();
