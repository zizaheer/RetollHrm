using RetollHrm.Data;

public static class ServiceExtension{
    public static IServiceCollection AddEmployeeServices(this IServiceCollection services)
    {
        // database: DESKTOP-H7FKF69\SQLDEV2019; user: retollhr; pass: retollHr@1234
        services.AddScoped<IEmployeeRepo, MockEmployeeRepo>();
        //services.AddScoped<IEmployeeRepo, MockEmployeeRepo>();
        //more services
        return services;
    }
}