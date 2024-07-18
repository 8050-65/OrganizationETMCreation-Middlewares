using Microsoft.EntityFrameworkCore;
using Mapster;
using MapsterMapper;
using OrganizationETMCreation.Data;
using OrganizationETMCreation.Interface;
using OrganizationETMCreation.Services;
using OrganizationETMCreation.Data.Repositories;
using OrganizationETMCreation.MapperProfile;
using OrganizationETMCreation.Repositories;

var builder = WebApplication.CreateBuilder(args);

//services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); 

// Registering DbContext
builder.Services.AddDbContext<DataContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Registering Mapster
var config = new TypeAdapterConfig();
builder.Services.AddTransient<Seed>();
builder.Services.AddSingleton(config);
builder.Services.AddScoped<IMapper, ServiceMapper>();


// Registering Services
builder.Services.AddScoped<IEmployeeServices, EmployeeService>();
//builder.Services.AddScoped<IEmployeeServices>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
// builder.Services.AddScoped<IEmployeeRepository>();
builder.Services.AddScoped<ITeamServices, TeamService>();
//builder.Services.AddScoped<ITeamServices>();
builder.Services.AddScoped<ITeamRepository, TeamRepository>();
// builder.Services.AddScoped<ITeamRepository>();
builder.Services.AddScoped<ITeamMemberServices, TeamMemberService>(); 
//builder.Services.AddScoped<ITeamServices>();
builder.Services.AddScoped<ITeamMemberRepository,TeamMemberRepository>();
// builder.Services.AddScoped<ITeamRepository>();


// Registering Mapster
builder.Services.AddScoped<MapsterMapper.IMapper, MapsterMapper.ServiceMapper>();
builder.Services.AddSingleton(Mapster.TypeAdapterConfig.GlobalSettings);

var app = builder.Build();

// the Mapster configuration
//MappingConfiguration.RegisterMappings();
MappingConfiguration.RegisterMappings();
//TypeAdapterConfig.GlobalSettings.Compile(); 

if (args.Length == 1 && args[0].ToLower() == "seeddata")
    SeedData(app);

void SeedData(IHost app)
{
    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

    using (var scope = scopedFactory.CreateScope())
    {
        var service = scope.ServiceProvider.GetService<Seed>();
        service.SeedDataContext();
    }
} 


//  the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


//var builder = WebApplication.CreateBuilder(args);

//    // Add services to the container.
//    builder.Services.AddControllers()
//        .AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

//    // Register Mapster
//    var config = TypeAdapterConfig.GlobalSettings;
//    builder.Services.AddScoped<IMapper, ServiceMapper>();

//    builder.Services.AddTransient<Seed>();
//    //builder.Services.AddSingleton(config);
//    //Employee e = new Employee();

//    // DbContext
//    string? connection = builder.Configuration.GetConnectionString("DefaultConnection");
//    builder.Services.AddDbContext<DataContext>(options =>
//        options.UseNpgsql(connection));

//    // Services
//    builder.Services.AddScoped<IEmployeeServices, EmployeeService>();
//    //builder.Services.AddScoped<IEmployeeServices>();
//    builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
//    // builder.Services.AddScoped<IEmployeeRepository>();
//    builder.Services.AddScoped<ITeamServices, TeamService>();
//    //builder.Services.AddScoped<ITeamServices>();
//    builder.Services.AddScoped<ITeamRepository, TeamRepository>();
//    // builder.Services.AddScoped<ITeamRepository>();

//    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//    builder.Services.AddEndpointsApiExplorer();
//    builder.Services.AddSwaggerGen();

//// Call the Mapster configuration
//MappingConfiguration.RegisterMappings();

//var app = builder.Build();
////if (someObject != null)
////{
////    // Access someObject properties
////}

//if (args.Length == 1 && args[0].ToLower() == "seeddata")
//    SeedData(app);


////static async Task Main(string[] args)
////{
////    var serviceProvider = ConfigureServices();

////    if (args.Length > 0 && args[0] == "seeddata")
////    {
////        await SeedDatabase(serviceProvider);
////    }
////    else
////    {
////        Console.WriteLine("Usage: dotnet run seeddata");
////    }
////}
///

//private static IServiceProvider ConfigureServices()
//{
//    var services = new ServiceCollection();

//    // Add your services here
//    services.AddTransient<SeedDataService>();
//    // Add other dependencies such as repositories, services, etc.

//    return services.BuildServiceProvider();
//}

////private static async Task SeedDatabase(IServiceProvider serviceProvider)
////{
////    using (var scope = serviceProvider.CreateScope())
////    {
////        var seedService = scope.ServiceProvider.GetRequiredService<SeedDataService>();

////        try
////        {
////            await seedService.SeedDataAsync();
////            Console.WriteLine("Database seeded successfully.");
////        }
////        catch (Exception ex)
////        {
////            Console.WriteLine($"Error seeding database: {ex.Message}");
////        }
////    }

//if (someObject != null)
//{
//    // Access someObject properties
//}
//void SeedData(IHost app)
//{
//    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

//    using (var scope = scopedFactory.CreateScope())
//    {
//        var service = scope.ServiceProvider.GetService<Seed>();
//        service.SeedDataContext();
//    }
//}

//    // Configure the HTTP request pipeline.
//    if (app.Environment.IsDevelopment())
//    {
//        app.UseSwagger();
//        app.UseSwaggerUI();
//    }

//    app.UseHttpsRedirection();
//    app.UseAuthorization();
//    app.MapControllers();
//    app.Run();

