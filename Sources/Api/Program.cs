using Application;
using Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddInfrastructure();
builder.Services.AddApplication();

var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

app.Run();
