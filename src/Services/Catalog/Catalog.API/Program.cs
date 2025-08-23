var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCarter();
// Add services to the container.
var assembly = typeof(Program).Assembly;
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(assembly);
});

var app = builder.Build();

app.MapCarter();

app.Run();
