var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Minimal API .NET 6 para cat�logo de m�sica!");

app.Run();
