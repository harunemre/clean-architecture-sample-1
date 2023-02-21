using CleanArchitectureSample1.Application;
using CleanArchitectureSample1.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
    .AddApplication()
    .AddInfrastructure(builder.Configuration);
    
    builder.Services.AddControllers();
}

var app = builder.Build();
{
    app.UseHttpsRedirection();

    app.MapControllers();

    app.Run();
}
