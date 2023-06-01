using Application.Core.Interfaces;

namespace Application.Infrastructure.Services
{
    public class Core : ICore
    {
        public string ServiceName()
        {
            return "I live in core";
        }
    }
}
