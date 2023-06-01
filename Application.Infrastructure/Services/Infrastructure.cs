using Application.Core.Interfaces;

namespace Application.Infrastructure.Services
{
    public class Infrastructure : IInfrastructure
    {
        public string ServiceName()
        {
            return "I live in infrastructure";
        }
    }
}
