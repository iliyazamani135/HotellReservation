using Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer("YourConnectionStringHere"));

        services.AddScoped<IClock, SystemClock>();
        services.AddScoped<IEmailSender, EmailSender>();

      
        return services;
    }
}
