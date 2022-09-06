namespace APIDemo.Startup;

public static class Injection
{
    public static IServiceCollection RegisterServices(this IServiceCollection services)
    {
       services.AddEndpointsApiExplorer();
       services.AddSwaggerGen();

        return services;
    }
}
