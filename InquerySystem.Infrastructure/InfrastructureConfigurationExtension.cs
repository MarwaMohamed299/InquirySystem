using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InquerySystem.Infrastructure
{
    public static class InfrastructureConfigurationExtension
    {
        public static IServiceCollection AddInfraStructureConfiguration(
        this IServiceCollection services,
        IConfiguration configuration)
        {
            return services;
        }
    }
}
