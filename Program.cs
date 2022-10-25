using APIMusicamin.Data;
using APIMusicamin.ViewModels;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("v1/musicas", (AppDbContext context) => {
    var musics = context.Musicas.ToList();
    return Results.Ok(musics);
}).Produces<Musica>();

app.MapPost("v1/musicas", (
    AppDbContext context,
    CriarMusicaViewModel model) => {

        var music = model.MapTo();
        if (!model.IsValid)
            return Results.BadRequest(model.Notifications);

        context.Musicas.Add(music);
        context.SaveChanges();

        return Results.Created($"/v1/musicas/{music.Id}", music);

    });

app.Run();
