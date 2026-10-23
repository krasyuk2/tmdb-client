var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.MapSwaggerUI();

app.UseSwagger();
app.UseAuthorization();
app.MapControllers();

app.Run();