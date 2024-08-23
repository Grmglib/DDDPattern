using DDDPattern.Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace DDDPattern.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            return services;
        }
    }
}
