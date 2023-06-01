using Application.Core.Interfaces;

public class ApiStartup
{
    private WebApplication _app;

    public ApiStartup(string[] args, Action<IServiceCollection> serviceCollection)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        serviceCollection.Invoke(builder.Services);

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        _app = builder.Build();

        // Configure the HTTP request pipeline.
        if (_app.Environment.IsDevelopment())
        {
            _app.UseSwagger();
            _app.UseSwaggerUI();
        }

        _app.UseHttpsRedirection();

        _app.UseAuthorization();

        _app.MapControllers();

        _app.MapGet("/core", (ICore coreService) => coreService.ServiceName());
        _app.MapGet("/infrastructure", (IInfrastructure infrastructureService) => infrastructureService.ServiceName());
    }

    public Task StartAsync()
    {
        return _app.RunAsync();
    }
}