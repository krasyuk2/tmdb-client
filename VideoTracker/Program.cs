using TmdbApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddTmdbClient(options => {});

var app = builder.Build();
app.MapSwaggerUI();

app.UseSwagger();
app.UseAuthorization();
app.MapControllers();

app.Run();