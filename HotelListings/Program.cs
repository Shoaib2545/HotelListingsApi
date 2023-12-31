using HotelListings.Configurations;
using HotelListings.IRepository;
using HotelListings.MyDbContext;
using HotelListings.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Events;

Log.Logger = new LoggerConfiguration()
.MinimumLevel.Debug()
.WriteTo.Console()
.WriteTo.File(
    path: "E:\\WorkSpace\\web_Engineering_dot_net\\HotelListings\\Logs\\log.txt",
    outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} {Level:u3}] {Message:lj}{NewLine}{Exception}",
    rollingInterval: RollingInterval.Day,
    restrictedToMinimumLevel: LogEventLevel.Information
    ).CreateLogger();
try {
    Log.Information("Application Is Starting");
    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.

    builder.Host.UseSerilog();
    builder.Services.AddTransient<IUnitOfWork , UnitOfWork>();
    builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection")));
    builder.Services.AddControllers().AddNewtonsoftJson(op => op.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
    builder.Services.AddCors(o =>
    {
        o.AddPolicy("AllowAll", aa =>
        aa.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()
        );
    });
    builder.Services.AddAutoMapper(typeof(MapperInitializer));
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
catch (Exception ex) {
    Log.Fatal(ex,"Application Fails To Start");

} finally { 
    Log.CloseAndFlush();
}
