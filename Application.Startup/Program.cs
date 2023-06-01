using Application.Core.Interfaces;
using Application.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

var apiStartup = new ApiStartup(args, services =>
{
    services.AddScoped<ICore, Core>();
    services.AddScoped<IInfrastructure, Infrastructure>();
});

await apiStartup.StartAsync();