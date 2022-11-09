using APIMusicamin.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("v1/musicas", (AppDbContext context) =>
{
    var musics = context.Musicas.ToList();
    return Results.Ok(musics);
});

app.Run();
