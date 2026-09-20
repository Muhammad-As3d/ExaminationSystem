namespace ExaminationSystem.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddCQRSConfig(typeof(ApplicationAssemblyMarker).Assembly);

        return services;
    }

    private static IServiceCollection AddCQRSConfig(this IServiceCollection services, params Assembly[] assemblies)
    {
        services.AddScoped<ISender, Sender>();

        if (assemblies.Length == 0)
            assemblies = [Assembly.GetCallingAssembly()];

        foreach (var assembly in assemblies)
        {
            var handlers = assembly.GetTypes()
                .Where(t => t is { IsClass: true, IsAbstract: false, IsGenericType: false })
                .SelectMany(t => t.GetInterfaces()
                    .Where(i => i.IsGenericType &&
                        (i.GetGenericTypeDefinition() == typeof(IRequestHandler<,>) ||
                            i.GetGenericTypeDefinition() == typeof(IRequestHandler<>)))
                    .Select(i => (Interface: i, Implementation: t)));

            foreach (var (iface, impl) in handlers)
                services.AddScoped(iface, impl);
        }

        return services;
    }
}
