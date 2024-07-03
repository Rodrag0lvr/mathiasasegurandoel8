using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using org.higx.platform.u202210587.Hign.Assessment.Application.Internal;
using org.higx.platform.u202210587.Hign.Assessment.Domain.Repositories;
using org.higx.platform.u202210587.Hign.Assessment.Domain.Services;
using org.higx.platform.u202210587.Hign.Assessment.Infrastructure.Persistence.EFC.Repositories;
using org.higx.platform.u202210587.Hign.Personnel.Application.Internal;
using org.higx.platform.u202210587.Hign.Personnel.Domain.Repositories;
using org.higx.platform.u202210587.Hign.Personnel.Domain.Services;
using org.higx.platform.u202210587.Hign.Personnel.Infrastructure.Persistence.EFC.Repositories;
using org.higx.platform.u202210587.Shared_web.Shared.Domain.Repositories;
using org.higx.platform.u202210587.Shared_web.Shared.Infrastructure.Interfaces.ASP.Configuration;
using org.higx.platform.u202210587.Shared_web.Shared.Infrastructure.Persistence.EFC.Configuration;
using org.higx.platform.u202210587.Shared_web.Shared.Infrastructure.Persistence.EFC.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options => options.Conventions.Add(new KebabCaseRoutingNamingConvention()));

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(
    options =>
    {
        if (connectionString != null)
            if (builder.Environment.IsDevelopment())
                options.UseMySQL(connectionString)
                    .LogTo(Console.WriteLine, LogLevel.Information)
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors();
            else if (builder.Environment.IsProduction())
                options.UseMySQL(connectionString)
                    .LogTo(Console.WriteLine, LogLevel.Error)
                    .EnableDetailedErrors();
    });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
    c =>
    {
           c.SwaggerDoc("v1", new OpenApiInfo { Title = "org.higx.platform.u202210587", Version = "v1" });
    });

builder.Services.AddRouting(options => options.LowercaseUrls = true);


builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped<IExaminerRepository, ExaminerRepository>();
builder.Services.AddScoped<IExaminerCommandService, ExaminerCommandService>();
builder.Services.AddScoped<IMentalRepository, MentalStateExamRepository>();
builder.Services.AddScoped<IMentalStateExamCommandService, MentalStateExamCommandService>();

var app = builder.Build();

// Verify Database Objects are created
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<AppDbContext>();
    context.Database.EnsureCreated();
}

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