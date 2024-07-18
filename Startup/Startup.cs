//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using OrganizationETMCreation.Data;
//using OrganizationETMCreation.Interface;
//using OrganizationETMCreation.Service;
//using OrganizationETMCreation;
//using Mapster;
//using OrganizationETMCreation.Services;

//public class Startup
//{
//    public void ConfigureServices(IServiceCollection services)
//    {
//        services.AddDbContext<DataContext>(options =>
//            options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));

//        services.AddScoped<IEmployeeService, EmployeeService>();
//        services.AddScoped<ITeamService, TeamService>();
//        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
//        services.AddScoped<ITeamRepository, TeamRepository>();

//        services.AddControllers();
//        services.AddMapster();

//        // Call the Mapster configuration
//        MapsterConfiguration.Configure();
//    }

//    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//    {
//        if (env.IsDevelopment())
//        {
//            app.UseDeveloperExceptionPage();
//        }

//        app.UseRouting();
//        app.UseEndpoints(endpoints =>
//        {
//            endpoints.MapControllers();
//        });
//    }
//}
